using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiteMvc.Models
{
    public class SalaViewModel
    {
        public List<AlunoViewModel> Alunos { get; set; }
    }
}