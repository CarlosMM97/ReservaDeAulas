using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaDeAulas
{
    public class Profesor
    {
        public enum TipoDocumento
        {
            Cedula,
            RUC,
            Pasaporte
        }
        private Int16 profesor_ID;
        private string nombreApellido;
        private string nroDocumento;
        private DateTime fechaNacimiento;
        private string email;
        private TipoDocumento venum_tipoDocumento;
        public static List<Profesor> listaProfesor = new List<Profesor>();

        public Int16 Profesor_ID
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

        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                fechaNacimiento = value;
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

        public TipoDocumento Venum_tipoDocumento
        {
            get
            {
                return venum_tipoDocumento;
            }

            set
            {
                venum_tipoDocumento = value;
            }
        }

        public static void AgregarProfesor(Profesor p)
        {

            listaProfesor.Add(p);

        }

        public static void EliminarProfesor(Profesor p)
        {
            listaProfesor.Remove(p);
        }

        public static List<Profesor> ObtenerListaProfesores()
        {
            return listaProfesor;
        }

        public override string ToString()
        {
            return this.NombreApellido;
        }
    }
}
