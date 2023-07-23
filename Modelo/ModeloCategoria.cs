using System;

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
        { get { return Cat_nome; }
            set {   Cat_nome = value; } 
        }
       

    }
}
