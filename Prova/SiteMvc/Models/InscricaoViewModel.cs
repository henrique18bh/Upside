using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiteMvc.Models
{
    public class InscricaoViewModel
    {
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Nome")]
        [StringLength(50, ErrorMessage = "Só é permitido no máximo 50 caracteres")]
        public string firstname { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "CPF")]
        [StringLength(20, ErrorMessage = "Só é permitido no máximo 50 caracteres")]
        public string cad_cpf { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}}")]
        [Display(Name = "Data de nascimento")]
        public DateTime cad_datanascimento { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "O Email está em um formato inválido")]
        [StringLength(50, ErrorMessage = "Só é permitido no máximo 50 caracteres")]
        public string emailaddress1 { get; set; }
    }
}