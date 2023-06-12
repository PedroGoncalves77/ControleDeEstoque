using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCategoria
    {
        private int Cat_cod { get; set; }
        private String Cat_nome { get; set; }
        public int CatCode
        {
            get { return this.Cat_cod; }
            set { this.Cat_cod = value; }
        }
        public String CatNome { get { return this.Cat_nome; }
            set {this.CatNome = value; } 
         }

    }
}
