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
    internal class DALCategoria
    {
        private DALConexao _Conexao; 
        //Construtor responsavel pela conexao 
        public DALCategoria(DALConexao cx) 
        {
            _Conexao = cx;
        }

        public void Incluir(ModeloCategoria modelo) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _Conexao.ObjetoConexao; // referenciado para o objeto da conexão em DALConexao
            cmd.CommandText = "insert into categoria (cat_nome) values (@nome); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.CatNome);
           
            _Conexao.Conectar();
            modelo.CatCod = Convert.ToInt32(cmd.ExecuteScalar());
            _Conexao.Desconectar();
        }
        public void Alterar(ModeloCategoria modelo) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _Conexao.ObjetoConexao;
            cmd.CommandText = "update categoria set cat_nome = @nome where cat_cod = @codigo;";
            cmd.Parameters.AddWithValue("@nome", modelo.CatNome);
            cmd.Parameters.AddWithValue("@codigo", modelo.CatCod);
            _Conexao.Conectar();
            cmd.ExecuteNonQuery();
            _Conexao.Desconectar();

        }
        public void Excluir (int codigo) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _Conexao.ObjetoConexao;
            cmd.CommandText = "delete from categoria where cat_codigo = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            _Conexao.Conectar();
            cmd.ExecuteNonQuery();
            _Conexao.Desconectar();

        }
        public DataTable Localizar(string valor) 
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter("Select * from categoria where cat_nome like '%" + valor + "%'", _Conexao.ObjetoConexao);
            data.Fill(tabela);
            return tabela;

        }
        public ModeloCategoria CarregaModeloCategoria(int codigo) 
        {
            var modelo = new ModeloCategoria();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _Conexao.ObjetoConexao;
            cmd.CommandText = "select * from categoria where cat_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            _Conexao.Conectar();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows) 
            {
                reader.Read();
                modelo.CatNome = (string)(reader["cat_nome"]);
                modelo.CatCod = (int)(reader["cat_cod"]);

            }
            _Conexao.Desconectar();
            return modelo;


        }
    }
    
}
