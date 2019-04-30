using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstadosCidadesBrasil
{
    public abstract class Estados
    {
        private string[] statesOfBrazil;

        /// <summary>
        /// Retorna todos os estados do Brasil em um componente ComboBox.
        /// </summary>
        /// <param name="cb"></param>
        public virtual ComboBox EstadosBrasil(ComboBox cb)
        {
            this.statesOfBrazil = new string[]
            {
                "Acre",
                "Alagoas",
                "Amapá",
                "Amazonas",
                "Bahia",
                "Ceará",
                "Distrito Federal",
                "Espírito Santo",
                "Goiás",
                "Maranhão",
                "Mato Grosso",
                "Mato Grosso do Sul",
                "Minas Gerais",
                "Pará",
                "Paraíba",
                "Paraná",
                "Pernambuco",
                "Piauí",
                "Rio de Janeiro",
                "Rio Grande do Norte",
                "Rio Grande do Sul",
                "Rondônia",
                "Roraima",
                "Santa Catarina",
                "São Paulo",
                "Sergipe",
                "Tocantins"
             };

            cb.Items.Add(statesOfBrazil);

            return cb;
        }
    }
}
