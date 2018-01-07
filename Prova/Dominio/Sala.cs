using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using ValueObjects;

namespace Dominio
{
    public class Sala : Base
    {


        private struct TipoColuna
        {
            public const int Nome = 0;
            public const int Sexo = 1;
            public const int Afinidade = 2;
        }
        public List<SalaValueObject> GerarSalas(Stream arquivo)
        {
            var salas = new List<SalaValueObject>();
            var Alunos = LerArquivo(arquivo);

            for (int i = 1; i <= 10; i++)
            {
                var capacidade = i * 10;
                salas.Add(CriarSala(capacidade, Alunos));
            }
            return salas;
        }

        private List<AlunoValueObject> LerArquivo(Stream arquivo)
        {
            var Alunos = new List<AlunoValueObject>();
            using (var parser = new TextFieldParser(arquivo))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");
                while (!parser.EndOfData)
                {
                    var linha = parser.ReadFields();
                    try
                    {
                        Alunos.Add(new AlunoValueObject
                        {
                            NomeCompleto = linha[TipoColuna.Nome],
                            Sexo = linha[TipoColuna.Sexo],
                            Afinidade = Convert.ToInt32(linha[TipoColuna.Afinidade])
                        });

                    }
                    catch (Exception ex)
                    {
                        //InserirMensagemErroLog(ex);
                    }
                }
            }
            return Alunos;
        }

        private SalaValueObject CriarSala(int capacidade, List<AlunoValueObject> alunos)
        {
            var sala = new SalaValueObject { Alunos = ObterAlunosPorAfinidade(capacidade, alunos) };
            while (sala.Alunos.Count() < capacidade)
            {
                sala.Alunos.AddRange(ObterAlunosPorAfinidade(capacidade - sala.Alunos.Count(), alunos));
            }

            return sala;
        }

        private List<AlunoValueObject> ObterAlunosPorAfinidade(int capacidade, List<AlunoValueObject> alunos)
        {
            var result = alunos.GroupBy(aluno => aluno.Afinidade)
                   .Select(grp => grp.First())
                   .Take(capacidade)
                   .ToList();

            foreach (var item in result)
            {
                alunos.Remove(item);
            }
            return result;
        }
    }
}
