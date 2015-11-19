using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;

namespace TAXWEB_TESTE.Models
{
    class DAL
    {

        public void GRAVA_VENDA(string comprador, string descricao, Decimal preco, int qtd,string endereco,string fornecedor)
        {
        
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database BANCO = factory.Create("TAX");
            System.Data.Common.DbCommand cmd = BANCO.GetStoredProcCommand("gravatax");
            BANCO.AddInParameter(cmd, "@comprador", DbType.String, comprador);
            BANCO.AddInParameter(cmd, "@descricao", DbType.String, descricao);
            BANCO.AddInParameter(cmd, "@preco", DbType.Decimal, preco);
            BANCO.AddInParameter(cmd, "@quantidade", DbType.Int16, qtd);
            BANCO.AddInParameter(cmd, "@endereco", DbType.String, endereco);
            BANCO.AddInParameter(cmd, "@fornecedor", DbType.String, fornecedor);
            BANCO.ExecuteNonQuery(cmd);
        }

        public DataTable LISTA_VENDA()
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database BANCO = factory.Create("TAX");
            System.Data.Common.DbCommand cmd = BANCO.GetStoredProcCommand("listataX");

            DataTable LISTANPROC = BANCO.ExecuteDataSet(cmd).Tables[0];
            return LISTANPROC;
        }

        public DataTable LISTA_TOTAL()
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database BANCO = factory.Create("TAX");
            System.Data.Common.DbCommand cmd = BANCO.GetStoredProcCommand("listataXTOTAL");

            DataTable LISTANPROC = BANCO.ExecuteDataSet(cmd).Tables[0];
            return LISTANPROC;
        }

    }
}
