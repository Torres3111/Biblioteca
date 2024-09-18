using Aula_02.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02.MODEL
{
    public class ClAutor
    {
        //public int Codigo { get; set; }
        private int _Id;
        private string _Nome;

        public int Id
        {

            get { return _Id; }
            set { _Id = value; }
        }
        public string Nome { get => _Nome; set => _Nome = value.Replace("'", ""); }


        public static List<ClAutor> ListarAutor()
        {
            return (from p in DataHelper.ListaAutor select p).ToList();

        }

        public static ClAutor? Seleciona(int Id)
        {
            return (from p in DataHelper.ListaAutor where p.Id == Id select p).FirstOrDefault();
        }

        public static void IncluirAutorStatic(ClAutor oAutor)
        {

        }
        public void Incluir()
        {
            ClAutor? oAutorSelecionado = Seleciona(Id);
            if (Seleciona(Id) != null)
            {
                throw new Exception($"O código está sendo utilizado no Autor {oAutorSelecionado.Nome}.");
            }
            else
            {


                DataHelper.ListaAutor.Add(this);
            }
        }
        public static void Alterar(ClAutor oAutor)
        {
            ClAutor? AutorColecao = Seleciona(oAutor.Id);
            if (AutorColecao == null)
            {

                throw new Exception($"O objeto informado não existe mais no contexto.");
            }
            else
            {

                AutorColecao.Id = oAutor.Id;
                AutorColecao.Nome = oAutor.Nome;
            }
            //public string Nome 
            //  { get { return _Nome; }      
            //set { _Nome = value; } }
        }

        public void Excluir()
        {
            DataHelper.ListaAutor.Remove(this);
        }
    }

}
