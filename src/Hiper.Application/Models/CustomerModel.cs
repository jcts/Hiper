using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hiper.Application.Models
{
    public class CustomerModel
    {
        [ScaffoldColumn(false)]
        public Guid Id { get; set; } = Guid.NewGuid();

        [DisplayName("Nome")]
        [MinLength(4, ErrorMessage = "O Nome deve conter no mínimo 4 caracteres")]
        public string FirstName { get; set; }

        [DisplayName("Sobrenome")]
        [MinLength(4, ErrorMessage = "O Nome deve conter no mínimo 4 caracteres")]
        public string LastName { get; set; }

        [DisplayName("Código Postal (CEP)")]
        public long ZipCode { get; set; }

        [DisplayName("Rua/Av")]
        public string Street { get; set; }

        [DisplayName("Número")]
        public int Number { get; set; }

        [DisplayName("Logradouro")]
        public string Neighborhood { get; set; }

        [DisplayName("Cidade")]
        public string City { get; set; }

        [DisplayName("Estado")]
        public string State { get; set; }

        [DisplayName("Complemento")]
        public string MoreInfo { get; set; }

        [DisplayName("Código do País")]
        public int CountryCode { get; set; }

        [DisplayName("DDD")]
        public int Ddd { get; set; }

        [DisplayName("Número de Telefone")]
        public int PhoneNumber { get; set; }

        public string CompletePhone
            => $"+{Ddd} ({Ddd}) {PhoneNumber}";

        public string FullName
            => $"{FirstName} {LastName}"; 

    }
}
