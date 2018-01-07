using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiteMvc.Models
{
    public class GerarSalaViewModel
    {
        [Display(Name = "Selecione um arquivo")]
        public string UploadTitle { get; set; }
        public List<SalaViewModel> Salas { get; set; }

    }
}