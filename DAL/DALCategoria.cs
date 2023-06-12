using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class DALCategoria
    {
        private DALConexao Conexao;   
        public DALCategoria(DALConexao cx) 
        {
            this.Conexao = cx;
        }
        public void Incluir(ModeloCategoria modelo) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexao.ObjetoConexao;
            cmd.CommandText = "insert into categoria (cat_nome) values (@nome); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.CatNome);
           
            Conexao.Conectar();
            modelo.CatCode = Convert.ToInt32(cmd.ExecuteScalar());
            Conexao.Desconectar();
        }
        public void Alterar(ModeloCategoria modelo) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexao.ObjetoConexao;
            cmd.CommandText = "update categoria set cat_nome = @nome where cat_cod = @codigo";
            cmd.Parameters.AddWithValue("@nome", modelo.CatNome);
            cmd.Parameters.AddWithValue("@codigo", modelo.CatCod);
            Conexao.Conectar();
            cmd.ExecuteNonQuery();
            Conexao.Desconectar();

        }
    }
    
}
