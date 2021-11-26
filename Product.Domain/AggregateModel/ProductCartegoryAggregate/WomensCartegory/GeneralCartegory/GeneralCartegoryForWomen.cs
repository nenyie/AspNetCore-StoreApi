using Product.Domain.AggregateModel.ProductCartegoryAggregate.WomensCartegory.DressCartegory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Domain.AggregateModel.ProductCartegoryAggregate.WomensCartegory.GeneralCartegory
{
    public class GeneralCartegoryForWomen
    {
        public Brand Brand { get; set; }           //photo[] from store pic, store or get from store service
        public Color Color { get; set; }
        public Size Size { get; set; }
        public Material Material { get; set; }
        public PatternType PatternType { get; set; }
        public Style Style { get; set; }
        public  Decoration Decoration{ get; set; }
        public FabricType FabricType { get; set; }      
        public Silhouette Silhouettte { get; set; }
        public SleeveLength SleeveLenth { get; set; }
        public SleeveStyle SleeveStyle { get; set; }

        // women's dress cartegory
        public WomenDressCartegory WomenDressCartegory { get; set; }
      
    }
}
