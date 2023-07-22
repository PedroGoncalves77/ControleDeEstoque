using DAL;
using Modelo;
using System;
using System.Data;

namespace BBL
{
    public class BLLCategoria
    {
        private DALConexao _conexao;
        public BLLCategoria(DALConexao cnx)
        {
            _conexao = cnx;
        }
        public void Incluir(ModeloCategoria modelo) 
        {
            if (modelo.CatNome.Trim().Length == 0)
            {
                throw new Exception("O Nome da categoria é obrigatorio");
            }

            modelo.CatNome = modelo.CatNome.TrimStart().Substring(0,1).ToUpper() + modelo.CatNome.Substring(1);

            DALCategoria dalObj = new DALCategoria(_conexao);
            dalObj.Incluir(modelo);
        }
        public void Alterar(ModeloCategoria modelo) 
        {

            if (modelo.CatCod <= 0 )
            {
                throw new Exception("O codigo da categoria é obrigatorio");
            }
            if (modelo.CatNome.Trim().Length == 0)
            {
                throw new Exception("O Nome da categoria é obrigatorio");
            }

            modelo.CatNome = modelo.CatNome.TrimStart().Substring(0, 1).ToUpper() + modelo.CatNome.Substring(1);

            DALCategoria dalObj = new DALCategoria(_conexao);
            dalObj.Alterar(modelo);
        }
        public void Excluir(int codigo) 
        {

            DALCategoria dalObj = new DALCategoria(_conexao);
            dalObj.Excluir(codigo);
        }
        public DataTable Localizar(string valor) 
        {
            DALCategoria dalObj = new DALCategoria(_conexao);
            return dalObj.Localizar(valor);
        }
        public ModeloCategoria CarregaModeloCategoria(int codigo) 
        {
            DALCategoria dalObj = new DALCategoria(_conexao);
            return dalObj.CarregaModeloCategoria(codigo);
        }

    }
}
