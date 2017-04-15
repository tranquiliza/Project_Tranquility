using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tranquility.Core.DomainModels.Webshop
{
    public class Dimensions
    {
        public virtual float Width { get; private set; }
        public virtual float Height { get; private set; }
        public virtual float Depth { get; private set; }

        protected Dimensions() { }

        public Dimensions(float width, float height, float depth)
        {
            Width = width;
            Height = height;
            Depth = depth;
        }
    }
}
