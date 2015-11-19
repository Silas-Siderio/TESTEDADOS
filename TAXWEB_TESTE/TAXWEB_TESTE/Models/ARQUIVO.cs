using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace TAXWEB_TESTE.Models
{
    public class ARQUIVO
    {
        public string caminho { get; set; }

      
        //PROCEDIMENTO QUE REALIZA A LEITURA DO ARQUIVO 
        public void READFILE()
        {

            Models.DAL dal = new Models.DAL();
            string strLine = string.Empty;

            string strarquivo = caminho;

            System.Collections.ArrayList arr = new System.Collections.ArrayList();

            StreamReader sr = new StreamReader(strarquivo, Encoding.GetEncoding("iso-8859-1"));

            while (sr.Peek() >= 0)

            {

                strarquivo = sr.ReadLine();

                arr.Add(strarquivo);

            }

            for (int i = 0; i < arr.Count; i++)

            {

                if (i == 1)

                {
                    string s1 = arr[i].ToString();
                    string t = s1.Length.ToString();
                    string s2 = s1.Substring(0, 11);
                    string s3 = s1.Substring(13, 20);
                    string s4 = s1.Substring(34, 4);
                    string s5 = s1.Substring(39, 1);
                    string s6 = s1.Substring(41, 10);
                    string s7 = s1.Substring(53, 10);

                    dal.GRAVA_VENDA(s2,s3,Convert.ToDecimal(s4),Convert.ToInt16(s5),s6,s7);
                }

                if (i == 2)

                {
                    string s1 = arr[i].ToString();
                    string t = s1.Length.ToString();
                    string s2 = s1.Substring(0, 9);
                    string s3 = s1.Substring(11, 23);
                    string s4 = s1.Substring(35, 4);
                    string s5 = s1.Substring(40, 1);
                    string s6 = s1.Substring(42, 13);
                    string s7 = s1.Substring(56, 19);

                    dal.GRAVA_VENDA(s2, s3, Convert.ToDecimal(s4), Convert.ToInt16(s5), s6, s7);
                }
                if (i == 3)

                {
                    string s1 = arr[i].ToString();
                    string t = s1.Length.ToString();
                    string s2 = s1.Substring(0, 12);
                    string s3 = s1.Substring(13, 21);
                    string s4 = s1.Substring(35, 3);
                    string s5 = s1.Substring(39, 1);
                    string s6 = s1.Substring(41, 11);
                    string s7 = s1.Substring(53, 22);
                    dal.GRAVA_VENDA(s2, s3, Convert.ToDecimal(s4), Convert.ToInt16(s5), s6, s7);
                }

                if (i == 4)

                {
                    string s1 = arr[i].ToString();
                    string t = s1.Length.ToString();
                    string s2 = s1.Substring(0, 15);
                    string s3 = s1.Substring(16, 21);
                    string s4 = s1.Substring(38, 3);
                    string s5 = s1.Substring(42, 1);
                    string s6 = s1.Substring(44, 11);
                    string s7 = s1.Substring(56, 22);

                    dal.GRAVA_VENDA(s2, s3, Convert.ToDecimal(s4), Convert.ToInt16(s5), s6, s7);
                }


             


            }

        }

    }
}

