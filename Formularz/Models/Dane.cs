using System.ComponentModel.DataAnnotations;

namespace Formularz.Models
{
    public class Dane
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Proszę podaj Imię")]
        [MinLength(2, ErrorMessage = "Imię musi miec co najmniej 2 znaki")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Proszę podaj Nazwisko")]
        [MinLength(2, ErrorMessage = "Nazwisko musi miec co najmniej 2 znaki")]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Prosze podaj Email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}", ErrorMessage = "Niepoprawny Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Prosze podaj Haslo")]
        [MinLength(8, ErrorMessage = "Haslo musi miec co najmniej 8 znakow")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$", ErrorMessage = "Haslo musi zawierac co najmniej jedna cyfre, jedną duza litere i jedna mała litere")]
        public string Haslo { get; set; }

        [Required(ErrorMessage = "Prosze powtorz Haslo")]
        [Compare("Haslo", ErrorMessage = "Hasla nie sa takie same")]
        public string PowtorzHaslo { get; set; }

        [Required(ErrorMessage = "Prosze podac numer telefonu")]
        [Phone(ErrorMessage = "Prosze podac prawidlowy numer telefonu")]
        public string NrTelefonu { get; set; }

        [Required(ErrorMessage = "Prosze podac wiek")]
        [MinLength(2, ErrorMessage = "Wiek musi się składac z 2 cyfr")]
        [Range(10, 80, ErrorMessage = "Wiek musi być pomiędzy 10 a 80 lat")]
        public string Wiek { get; set; }

        [Required(ErrorMessage = "Proszę wybrać miasto")]
        public Kategorie Miasto { get; set; }

        public enum Kategorie
        {
            Warszawa = 1,
            Krakow = 2,
            Gdansk = 3,
            Myslenice = 4,
            Skawina = 5,
        }
    }
}
