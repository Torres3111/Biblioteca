using Aula_02.Helper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02.MODEL
{
    public class GENERO
    {
        //public int Codigo { get; set; }
        private int _Codigo;
        private string _Nome;

        public int Codigo
        {

            get { return _Codigo; }
            set { _Codigo = value; }
        }
        public string Nome { get => _Nome; set => _Nome = value.Replace("'", ""); }


        public static List<GENERO> ListarTodos()
        {
            //  return (from p in DataHelper.ListaGenero select p).ToList();
            using (var oCn = DataHelper.Conexao())
            {
                List<GENERO> Retorno = new List<GENERO>();
                string SQL = "select id, Nome from Genero";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    GENERO oGenero = new GENERO();
                    oGenero.Codigo = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oGenero.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));


                    Retorno.Add(oGenero);
                }
                oDr.Close();
                return Retorno;
            }
            
            //SqlConnection oCn = DataHelper.Conexao();

            //oCn.Close();

        }

        public static GENERO? Seleciona(int Codigo)
        {
            return (from p in DataHelper.ListaGenero where p.Codigo == Codigo select p).FirstOrDefault();
        }

        public static void IncluirGeneroStatic(GENERO oGenero)
        {

        }
        public void Incluir()
        {
            GENERO? oGeneroSelecionado = Seleciona(Codigo);
            if (Seleciona(Codigo) != null)
            {
                throw new Exception($"O código está sendo utilizado no gênero {oGeneroSelecionado.Nome}.");
            }
            else
            {


                DataHelper.ListaGenero.Add(this);
            }
        }
        public static void Alterar(GENERO oGenero)
        {
            GENERO? GeneroColecao = Seleciona(oGenero.Codigo);
            if (GeneroColecao == null)
            {

                throw new Exception($"O objeto informado não existe mais no contexto.");
            }
            else
            {

                GeneroColecao.Codigo = oGenero.Codigo;
                GeneroColecao.Nome = oGenero.Nome;
            }
            //public string Nome 
            //  { get { return _Nome; }      
            //set { _Nome = value; } }
        }

        public void Excluir()
        {
            DataHelper.ListaGenero.Remove(this);
        }
    }



}