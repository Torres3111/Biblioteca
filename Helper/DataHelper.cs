﻿using AulaAEDB01.Windows.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
namespace AulaAEDB01.Windows.Helper
{
    public static class DataHelper
    {
       public static List<Genero> ListaGenero { get; set; }
        
       public static List<Autor> ListaAutor { get; set; } 
        
       public static List<Editora> ListaEditora {  get; set; }

       public static List<Idioma> ListaIdioma { get; set; }

       public static List<Usuario> ListaUsuario { get; set; }

       public static List<Livro> ListaLivro { get; set; }   

        public static List<LogIn> ListaLogin {  get; set; }
        public static SqlConnection Conexao()
        {
            string strconnection = "Data Source=DESKTOP-G83281E\\SQLEXPRESS;Initial Catalog=biblioteca;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=True"; 
            SqlConnection oCn = new SqlConnection(strconnection);
            oCn.Open();
            return oCn;
        }
    }
}
