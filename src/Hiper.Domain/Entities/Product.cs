using System.ComponentModel.DataAnnotations.Schema;

namespace Hiper.Domain.Entities
{
    /// <summary>
    /// Classe para representação de Produto
    /// </summary>
    public sealed class Product : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsEnable { get; set; }
        public long Code { get; set; }
    }
}
