using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class ModuloUsuario : BusinessEntity
    {
        private int idU, idM;
        private bool pA, pB, pM, pC;
        public int udUsuario
        {
            get => this.idU;
            set => this.idU = value;
        }
        public int idModulo
        {
            get => this.idM;
            set => this.idM = value;
        }
        public bool permiteAlta
        {
            get => this.pA;
            set => this.pA = value;
        }
        public bool permiteBaja
        {
            get => this.pB;
            set => this.pB = value;
        }
        public bool permiteModificacion
        {
            get => this.pM;
            set => this.pM = value;
        }
        public bool permiteConsulta
        {
            get => this.pC;
            set => this.pC = value;
        }
    }
}
