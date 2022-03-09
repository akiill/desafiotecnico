using System;
using System.ComponentModel.DataAnnotations;

namespace ApiDesafio.Models
{
    public class DecomporRequest
    {
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        [Required(ErrorMessage = "{0} é um campo obrigatório")]
        public string email { get; set; }

        [Required(ErrorMessage = "{0} é um campo obrigatório")]
		[Range(1, int.MaxValue, ErrorMessage = "{0} não pode ser nulo ou menor que zero")]
		public long numero { get; set; }
	}
}