using Aula_02.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula_02.Mock;
using Aula_02.MODEL;

namespace Aula_02.Mock
{
    public class MockAutor
    {

        public static void CarregaAutor()
        {
            List<ClAutor> oLISTA = new List<ClAutor>();

            for (int i = 1; i < 11; i++)
            {
                //  GENERO oGENERO = new GENERO();
                //  oGENERO.Codigo = i;
                //  oGENERO.Nome = $"Gênero {i}";
                // oLISTA.Add(oGENERO);
                ClAutor oAutor = new ClAutor
                {
                    Id = i,
                    Nome = $"Autor {i}"

                };
                oLISTA.Add(oAutor);
            }
            DataHelper.ListaAutor = oLISTA;
        }
    }
}
