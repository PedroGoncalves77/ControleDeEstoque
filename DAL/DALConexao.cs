﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALConexao
    {
        private string _stringConexao;
        private SqlConnection _conexao;
        // Construtor responsavel por realizar a conexao com o banco de dados
        public DALConexao(string dadosConexao) 
        {
            this._conexao = new SqlConnection();
            this._stringConexao = dadosConexao;
            this._conexao.ConnectionString = dadosConexao;
            
        }
        public string StringConexao { 
            get { return this._stringConexao; }
            set  { this._stringConexao = value; } 
        }
        public SqlConnection ObjetoConexao 
        {get { return this._conexao; }
            set { this._conexao = value; }
        }
        public void Conectar() 
        {
            this._conexao.Open();
        }
        public void Desconectar() 
        {
            this._conexao.Close();
        } 
    }
}
