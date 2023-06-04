using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SRP_proyecto.Models
{
    public class CarritoItem
    {
        private tb_espacio _tb_espacio;
        public tb_espacio Espacio { get 
            { return _tb_espacio; } 
            set { _tb_espacio = value; }
        }
        private int _cantidad;
        public int Cantidad { get 
            { return _cantidad; } 
            set { _cantidad=value; } 
        }      
        public CarritoItem(tb_espacio espacio, int cantidad)
        {
            this._tb_espacio=espacio;
            this._cantidad=cantidad;
        }
    }
}//semana 9- semana 10