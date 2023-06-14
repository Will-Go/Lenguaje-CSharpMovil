using System;
using System.Collections.Generic;
using System.Text;

namespace pruebaMaterialDesign
{

    class Producto
    {
        public string Nombre { get; set; }
        public string Url { get; set; }

        public Producto( string Nombre, string Url) 
        {
            this.Nombre = Nombre; 
            this.Url = Url;
        }   
    }
}
