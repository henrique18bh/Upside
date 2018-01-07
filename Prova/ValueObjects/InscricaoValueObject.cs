using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObjects
{
    public class InscricaoValueObject
    {
        public string firstname { get; set; }

        public string cad_cpf { get; set; }

        public DateTime cad_datanascimento { get; set; }

        public string emailaddress1 { get; set; }
    }
}
