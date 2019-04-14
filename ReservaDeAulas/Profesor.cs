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
        private string nail;
        private int tipoDocumento_tipoDocumntoID;

        public int Profesor_ID { get => profesor_ID; set => profesor_ID = value; }
        public string NombreApellido { get => nombreApellido; set => nombreApellido = value; }
        public string NroDocumento { get => nroDocumento; set => nroDocumento = value; }
        public string NechaNacimiento { get => nechaNacimiento; set => nechaNacimiento = value; }
        public string Nail { get => nail; set => nail = value; }
        public int TipoDocumento_tipoDocumntoID { get => tipoDocumento_tipoDocumntoID; set => tipoDocumento_tipoDocumntoID = value; }
    }
}
