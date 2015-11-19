using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;
//using Microsoft.SqlServer.Dts.Runtime;

namespace TAXWEB_TESTE
{
    public partial class _Default : Page
    {
 

        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (fup.HasFile)
            {
                try
                {
                    // VERIFICA O TAMANHO DO ARQUIVO , SE ELE É UM ARQUIVO TXT E REALIZA O UPLOAD PATA O LOCAL ESPECÍFICADO .
                    if (fup.PostedFile.ContentType == "text/plain")
                    {
                        if (fup.PostedFile.ContentLength < 102400)
                        {
                           
                            string filename = Path.GetFileName(fup.FileName);
                            string targetFolder = HttpContext.Current.Server.MapPath("~/UploadFolder/");
                            string targetPath = Path.Combine(targetFolder, filename);
                            fup.PostedFile.SaveAs(targetPath);
                            string txt = targetPath;
                            Models.ARQUIVO arq = new Models.ARQUIVO();
                            arq.caminho = txt;
                            StatusLabel.Text = "Upload status: Arquivo carregado!";
                        }
                        else
                            StatusLabel.Text = "Upload status: O arquivo deve ser menor que 100 kb!";
                    }
                    else
                        StatusLabel.Text = "Upload status: Apenas arquivos com extensão *.txt , serão aceitos!";
                }
                catch (Exception ex)
                {
                    StatusLabel.Text = "Upload status: O arquivo não pôde ser carregado. Segue o erro ocorrído: " + ex.Message;
                }
                // REALIZA A LEITURA O PARSE DOS REGISTROS DO ARQUIVO
                string filenames = Path.GetFileName(fup.FileName);
                string targetFolders = HttpContext.Current.Server.MapPath("~/UploadFolder/");
                string targetPaths = Path.Combine(targetFolders, filenames);
                string txts = targetPaths;
                Models.ARQUIVO arquivo = new Models.ARQUIVO();
                arquivo.caminho = txts;
                arquivo.READFILE();

                // EXIBE  OS REGISTROS GRAVDOS E CALCULA O TOTAL DAS VENDAS

                Models.DAL lista = new Models.DAL();
                GridView1.DataSource = lista.LISTA_VENDA();
                GridView1.DataBind();
                Label1.Text = " O TOTAL DE VENDAS É DE  " + lista.LISTA_TOTAL().Rows[0].ItemArray[0].ToString() + " R$";
            }

            else
                StatusLabel.Text = "Upload status: Escolha um arquivo à ser carregado!";
        }

     
    }
}