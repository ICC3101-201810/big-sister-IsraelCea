using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPOO
{
    [Serializable]
    class HermanaGrande
    {
        public delegate void QuitarProducto( Product producto, List<Product> receta, List<Product> carro);
        public event QuitarProducto ProductoNoPertenece;

        public void Revisar( Product producto, List<Product> receta, List<Product> carro)
        {
            bool pertenece=false;
            var evento = ProductoNoPertenece;
            foreach(Product p in receta)
            {
                if(producto.Name==p.Name)
                {
                    pertenece = true;
                    Console.WriteLine("Está en la receta, agregado");
                    break;
                    
                }
                else if(producto.Name!=p.Name )
                {
                    pertenece = false;
                    Console.WriteLine("No está en la receta, lo quitamos!");
                }
            }

            if (pertenece==false)
            { evento(producto, receta,carro); }
        }
    }
}
