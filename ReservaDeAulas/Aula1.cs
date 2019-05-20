using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaDeAulas
{

    public enum Tipo_Aula
    {
        Normal,
        AudioVisual,
        Laboratorio,
        Conferencia
    }
    public enum Piso
    {
        PlantaBaja,
        Primer,
        Segundo,
        Tercer,
        Cuarto,
        Quinto,
        Sexto,
        Septimo

    }

    public class Aula1
    {
        private String nro_Aula;
        private String cant_alumnos;
        private Tipo_Aula tipo_aula;
        private Piso piso;
        private bool proyector;
        public static List<Aula1> listaAulas = new List<Aula1>();

        public String Nro_Aula
        {
            get
            {
                return nro_Aula;
            }

            set
            {
                nro_Aula = value;
            }
        }
        public String Cant_Alumnos
        {
            get
            {
                return cant_alumnos;
            }

            set
            {
                cant_alumnos = value;
            }
        }

        public Piso Venum_piso
        {
            get
            {
                return piso;
            }

            set
            {
                piso = value;
            }

        }
        public Tipo_Aula Venum_Tipo_aula
        {
            get
            {
                return tipo_aula;
            }
            set
            {
                tipo_aula = value;
            }
        }

        public bool Proyector
        {
            get
            {
                return proyector;
            }
            set
            {
                proyector = value;
            }

        }


        public static void AgregarAula(Aula1 a)
        {
            listaAulas.Add(a);
        }
        public static void EliminarAula(Aula1 a)
        {
            listaAulas.Remove(a);
        }
        public static List<Aula1> ObtenerAulas()
        {
            return listaAulas;
        }






    }
}

