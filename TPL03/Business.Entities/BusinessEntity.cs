using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class BusinessEntity
    {
        public States states;
        public int id;
        public BusinessEntity()
        {
            this.State = new States();
        }
        public int ID
        {
            get=>this.id; 
            set=>this.id=value; 
        }
        public States State{
            get=> this.states;
            set=>this.states=value; }
        public enum States
        {
            Deleted,
            New,
            Modified,
            Unmodified
        }
    }
}
