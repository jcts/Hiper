using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hiper.Application.Models
{
    public class ProductViewModel
    {
        [ScaffoldColumn(false)]
        public Guid Id { get; set; }

        [DisplayName("Nome")]
        public string Name { get; set; }

        [DisplayName("Descrição")]
        public string Description { get; set; }
        
        [DisplayName("Valor")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [ScaffoldColumn(false)]
        public bool IsEnable { get; set; }

        [DisplayName("Código de Identificação")]
        public long Code { get; set; }
    }
}
