using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.ProductRelated
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public long Barcode { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }        
        public int BatchNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string InvoiceNo { get; set; }
        public string Origin { get; set; }
        public decimal UnitPrice { get; set; }
        public int InspectedBatchQuantity { get; set; }
        public int InspectedQuantity { get; set; }
        public int InvoiceQuantity { get; set; }
        public int RelatedRegulationId { get; set; }

    }
}
