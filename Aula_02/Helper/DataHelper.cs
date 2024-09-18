using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula_02.MODEL;
using Microsoft.Data.SqlClient;

namespace Aula_02.Helper
{
    public static class DataHelper
    {
        public static List<GENERO> ListaGenero { get; set; }
        public static List<ClAutor> ListaAutor { get; set; }

        public static SqlConnection Conexao()
        {
            string strconnection = "Data Source=DESKTOP-G83281E\\SQLEXPRESS;Initial Catalog=testeee;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=True;";
            SqlConnection oCn = new SqlConnection(strconnection);
            oCn.Open();
            return oCn;

            
            
        }

    }

}
