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
        private bool pB, pA, pM, pC;
        public int IdUsuario { get=>this.idU; set => this.idU=value; }
        public int IdModulo { get => this.idM; set => this.idM=value; }
        public bool Permitebaja { get => this.pB; set => this.pB=value; }
        public bool PermiteAlta { get => this.pA; set => this.pA=value; }
        public bool PermiteMod { get => this.pM; set => this.pM=value; }
        public bool PermiteConsulta { get => this.pC; set => this.pC=value; }
    }
}
