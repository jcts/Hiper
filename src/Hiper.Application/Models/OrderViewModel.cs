using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hiper.Application.Models
{
    public class OrderViewModel
    {
        [ScaffoldColumn(false)]
        public Guid Id { get; set; }


        [ScaffoldColumn(false)]
        public bool IsEnable { get; set; }

        [DisplayName("Pedido Expira em")]
        public DateTime EndDate { get; set; }

        [DataType(DataType.Currency)]
        public decimal? Ammount { get; set; }

        [DisplayName("Número do Pedido")]
        public int Number { get; set; }

        [ScaffoldColumn(false)]
        public Guid CustomerId { get; set; }
    }
}
