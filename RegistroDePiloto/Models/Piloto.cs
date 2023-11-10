using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace RegistroDePiloto.Models
{
    public class Piloto
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do piloto é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A idade do piloto é obrigatória.")]
        public int Idade { get; set; }

        public string Nacionalidade { get; set; }

        [Required(ErrorMessage = "O número de licença é obrigatório.")]
        public string NumeroLicenca { get; set; }

        [Display(Name = "Data de Expiração da Licença")]
        [Required(ErrorMessage = "A data de expiração da licença é obrigatória.")]
        [DataType(DataType.Date)]
        public DateTime DataExpiracaoLicenca { get; set; }

        [Display(Name = "Tipo de Licença")]
        public TipoLicenca TipoLicencaPiloto { get; set; }
    }

    public enum TipoLicenca
    {
        Amador,
        Nacional,
        Internacional,
        Formula1,
        Rally,
        Kart,
        Arrancada,
        ClubeEsportivo
    }
}
