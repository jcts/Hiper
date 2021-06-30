using System;
using System.Collections.Generic;

namespace Hiper.Domain.Entities
{
    /// <summary>
    /// Classe para representação de Pedido
    /// </summary>
    
    public class Order : EntityBase
    {
        public ICollection<Product> Itens { get; set; }
        public bool IsEnable { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Ammount { get; set; }

        public virtual Guid CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
