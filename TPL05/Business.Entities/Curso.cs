using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Curso: BusinessEntity
    {
        private int _AnioCalendario;
        private int _Cupo;
        private String _Descripcion;
        private int _IDComision;
        private int _ID_Materia;

        public int AnioCalendario
        {
            get => default;
            set
            {
            }
        }

        public int Cupo
        {
            get => default;
            set
            {
            }
        }

        public String Descripcion
        {
            get => default;
            set
            {
            }
        }

        public int IDComision
        {
            get => default;
            set
            {
            }
        }

        public int IDMateria
        {
            get => default;
            set
            {
            }
        }
    }
}