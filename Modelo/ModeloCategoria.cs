using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Armazena as classes relacionadas a tabela do banco.
namespace Modelo
{
    // Tabela da categoria
    public class ModeloCategoria
    {
        private int Cat_cod { get; set; }
        private String Cat_nome { get; set; } 
        
        // Codigo da categoria
        public int CatCod
        {
            get { return this.Cat_cod; }
            set { this.Cat_cod = value; }
        }
        // Nome da categoria
        public String CatNome 
        { get { return this.Cat_nome; }
            set {this.CatNome = value; } 
        }
       

    }
}
