using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaDeAulas
{
    public class Profesor
    {
        private int profesor_ID;
        private string nombreApellido;
        private string nroDocumento;
        private string nechaNacimiento;
        private string email;
        private int tipoDocumento_tipoDocumntoID;

        public int Profesor_ID
        {
            get
            {
                return profesor_ID;
            }

            set
            {
                profesor_ID = value;
            }
        }

        public string NombreApellido
        {
            get
            {
                return nombreApellido;
            }

            set
            {
                nombreApellido = value;
            }
        }

        public string NroDocumento
        {
            get
            {
                return nroDocumento;
            }

            set
            {
                nroDocumento = value;
            }
        }

        public string NechaNacimiento
        {
            get
            {
                return nechaNacimiento;
            }

            set
            {
                nechaNacimiento = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public int TipoDocumento_tipoDocumntoID
        {
            get
            {
                return tipoDocumento_tipoDocumntoID;
            }

            set
            {
                tipoDocumento_tipoDocumntoID = value;
            }
        }
    }
}
