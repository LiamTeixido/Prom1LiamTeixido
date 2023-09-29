using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1LiamTeixido
{
    public class ProductClay : Product, IMaterial
    {
        private string name;
        private int size;
        private string color;
        private int price;
        private string material;
        private int weight;

        public ProductClay(string name, int size, string color, int price, string material, int weight)
        {
            this.name = name;
            this.size = size;
            this.color = color;
            this.price = price;
            this.weight = weight;
            this.material = material;
        }

        public override string GetFeatures()
        {
            return $"Nombre: {name}, Tamaño: {size}, Color: {color}, Precio: {price}, Peso: {weight}, Material: {material}";
        }

        public override string GetName()
        {
            return name;
        }

        public override int GetPrice()
        {
            return price;
        }
    }
}
