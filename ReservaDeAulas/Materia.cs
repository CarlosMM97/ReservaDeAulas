using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaDeAulas
{
    class Materia
    {
        private int materia_ID;
        private string descripcion;

        public int Materia_ID
        {
            get
            {
                return materia_ID;
            }

            set
            {
                materia_ID = value;
            }
        }
        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }
    }
}
