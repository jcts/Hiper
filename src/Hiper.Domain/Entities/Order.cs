using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hiper.Domain.Entities
{
    /// <summary>
    /// Classe para representação de Pedido
    /// </summary>
    [Table("Orders")]
    public class Order : EntityBase
    {
        public ICollection<Product> Itens { get; set; }
        public bool IsEnable { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Ammount { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
    }
}
