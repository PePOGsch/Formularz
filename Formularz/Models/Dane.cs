﻿using System.ComponentModel.DataAnnotations;

namespace Formularz.Models
{
    public class Dane
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Proszę podaj Imię")]
        public string Imie { get; set; }
        [Required(ErrorMessage = "Prosze podaj Email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Prosze podaj Temat")]
        public string Temat { get; set; }
        [Required(ErrorMessage = "Prosze podaj Tresc wiadomosci")]
        [MinLength(10), MaxLength(50)]
        public string Tresc { get; set; }
    }
}