using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Usuario
    {
        private String nomU,cla,ape,nom,ema;
        private bool hab;
        public String NombreUsuario
        {
            get=>this.nomU; 
            set=> this.nomU=value; 
        }
        public String Clave
        {
            get => this.cla;
            set => this.cla=value;
        }
        public String Nombre
        { 
            get => this.nom; 
            set => this.nom=value;
        }
        public String Apellido
        { 
            get => this.ape; 
            set => this.ape=value; 
        }
        public String Email 
        { 
            get => this.ema; 
            set => this.ema=value; 
        }
        public bool Habilitado
        { 
            get => this.hab; 
            set => this.hab=value; 
        }

    }
}
