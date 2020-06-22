using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSeguros.Models
{
    public class Localizar
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [Display(Name = "CPF")]
        public String Cpf { get; set; }

        public int IdCliente { get; set; }

        public int IdCarro { get; set; }
    }
}
