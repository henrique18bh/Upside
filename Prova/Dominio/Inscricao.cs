using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObjects;

namespace Dominio
{
    public class Inscricao : Base
    {
        public string Salvar(InscricaoValueObject entidade)
        {
            var response = Salvar<InscricaoValueObject>(entidade, "integracao.aspx");
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return response.ErrorMessage;
            }
            return string.Empty;
        }
    }
}
