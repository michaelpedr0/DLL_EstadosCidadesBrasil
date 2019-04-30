using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstadosCidadesBrasil
{
    public abstract class Cidades
    {
        //Vetor que armazenará as cidades dos estados do Brasil.
        private string[] citiesOfBrazil;

        /// <summary>
        /// Retorna em um componente ComboBox a lista de cidades pertencentes ao estado do Acre.
        /// </summary>
        /// <param name="cb">Componente ComboBox que receberá o retorno das cidades.</param>
        public virtual ComboBox Acre(ComboBox cb)
        {
            citiesOfBrazil = new string[]
            {
                "Acrelandia", "Assis Brasil",

                "Brasileia", "Bujari",

                "Capixaba", "Cruzeiro do Sul",

                "Epitaciolandia",

                "Feijo",

                "Jordao",

                "Mancio Lima", "Manoel Urbano", "Marechal Thaumaturgo",

                "Placido de Castro", "Porto Acre", "Porto Walter",

                "Rio Branco", "Rodrigues Alves",

                "Santa Rosa do Purus", "Sena Madureira", "Senador Guiomard",

                "Tarauaca",

                "Xapuri"
            };

            cb.Items.AddRange(citiesOfBrazil);

            return cb;
        }        
    }
}
