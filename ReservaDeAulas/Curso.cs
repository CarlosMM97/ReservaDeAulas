using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaDeAulas
{
    public class Curso
    {
        private String diaDeClase;
        private TimeSpan hora;
        private DateTime anho;
        private int cantidadAlumnos;
        private int materia_materia_ID;
        private int turno_turno_ID;
        private int aula_numeroAula_ID;
        private int arofesor_profesor_ID;
        private int semestre_semestre_ID;

        public string DiaDeClase
        {
            get
            {
                return diaDeClase;
            }

            set
            {
                diaDeClase = value;
            }
        }

        public TimeSpan Hora
        {
            get
            {
                return hora;
            }

            set
            {
                hora = value;
            }
        }

        public DateTime Anho
        {
            get
            {
                return anho;
            }

            set
            {
                anho = value;
            }
        }

        public int CantidadAlumnos
        {
            get
            {
                return cantidadAlumnos;
            }

            set
            {
                cantidadAlumnos = value;
            }
        }

        public int Materia_materia_ID
        {
            get
            {
                return materia_materia_ID;
            }

            set
            {
                materia_materia_ID = value;
            }
        }

        public int Turno_turno_ID
        {
            get
            {
                return turno_turno_ID;
            }

            set
            {
                turno_turno_ID = value;
            }
        }

        public int Aula_numeroAula_ID
        {
            get
            {
                return aula_numeroAula_ID;
            }

            set
            {
                aula_numeroAula_ID = value;
            }
        }

        public int Arofesor_profesor_ID
        {
            get
            {
                return arofesor_profesor_ID;
            }

            set
            {
                arofesor_profesor_ID = value;
            }
        }

        public int Semestre_semestre_ID
        {
            get
            {
                return semestre_semestre_ID;
            }

            set
            {
                semestre_semestre_ID = value;
            }
        }
    }
}