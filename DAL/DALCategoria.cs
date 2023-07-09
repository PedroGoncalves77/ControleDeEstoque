using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCategoria
    {
        private DALConexao _conexao; 
        //Construtor responsavel pela conexao 
        public DALCategoria(DALConexao cnx) 
        {
            _conexao = cnx;
        }

        public void Incluir(ModeloCategoria modelo) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conexao.ObjetoConexao; // referenciado para o objeto da conexão em DALConexao
            cmd.CommandText = "insert into categoria (cat_nome) values (@nome); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.CatNome);
           
            _conexao.Conectar();
            modelo.CatCod = Convert.ToInt32(cmd.ExecuteScalar());
            _conexao.Desconectar();
        }
        public void Alterar(ModeloCategoria modelo) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conexao.ObjetoConexao;
            cmd.CommandText = "update categoria set cat_nome = @nome where cat_cod = @codigo;";
            cmd.Parameters.AddWithValue("@nome", modelo.CatNome);
            cmd.Parameters.AddWithValue("@codigo", modelo.CatCod);
            _conexao.Conectar();
            cmd.ExecuteNonQuery();
            _conexao.Desconectar();

        }
        public void Excluir (int codigo) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conexao.ObjetoConexao;
            cmd.CommandText = "delete from categoria where cat_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            _conexao.Conectar();
            cmd.ExecuteNonQuery();
            _conexao.Desconectar();

        }
        public DataTable Localizar(string valor) 
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter("Select * from categoria where cat_nome like '%" + valor + "%'", _conexao.ObjetoConexao);
            data.Fill(tabela);
            return tabela;

        }
        public ModeloCategoria CarregaModeloCategoria(int codigo) 
        {
            var modelo = new ModeloCategoria();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conexao.ObjetoConexao;
            cmd.CommandText = "select * from categoria where cat_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            _conexao.Conectar();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows) 
            {
                reader.Read();
                modelo.CatNome = (string)(reader["cat_nome"]);
                modelo.CatCod = (int)(reader["cat_cod"]);

            }
            _conexao.Desconectar();
            return modelo;


        }
    }
    
}
