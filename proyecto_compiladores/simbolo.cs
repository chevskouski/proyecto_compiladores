using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_compiladores
{
    class simbolo
    {
        private string id_simbolo;
        private string tipo_simbolo;
        public string Id_Simbolo
        {
            get
            {
                return this.id_simbolo;
            }
            set
            {
                this.id_simbolo = value;
            }
        }
        public string Tipo_Simbolo
        {
            get
            {
                return this.tipo_simbolo;
            }
            set
            {
                this.tipo_simbolo = value;
            }
        }
    }
}
