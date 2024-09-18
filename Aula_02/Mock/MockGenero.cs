using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula_02.Mock;
using Aula_02.Helper;
using Aula_02.MODEL;


namespace Aula_02.Mock
{
    public class MockGenero
    {
        public static void CarregaGenero()
        {
            List<GENERO> oLISTA = new List<GENERO>();

            for (int i = 1; i < 11; i++)
            {
                //  GENERO oGENERO = new GENERO();
                //  oGENERO.Codigo = i;
                //  oGENERO.Nome = $"Gênero {i}";
                // oLISTA.Add(oGENERO);
                GENERO oGENERO = new GENERO
                {
                    Codigo = i,
                    Nome = $"Gênero {i}"

                };        
                oLISTA.Add(oGENERO);
            }    
            DataHelper.ListaGenero = oLISTA;
        }
    }
}
