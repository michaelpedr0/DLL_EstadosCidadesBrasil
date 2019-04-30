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

        /// <summary>
        /// Retorna em um componente ComboBox a lista de cidades pertencentes ao estado de Alagoas.
        /// </summary>
        /// <param name="cb">Componente ComboBox que receberá o retorno das cidades.</param>
        public virtual ComboBox Alagoas(ComboBox cb)
        {
            citiesOfBrazil = new string[]
            {
                "Água Branca", "Anadia", "Arapiraca", "Atalaia",

                "Barra de Santo Antônio", "Barra de São Miguel", "Batalha", "Belém",
                "Belo Monte", "Boca da Mata", "Branquinha",

                "Cacimbinhas", "Cajueiro", "Campestre", "Campo Alegre", "Campo Grande",
                "Canapi", "Capela", "Carneiros", "Chã Preta", "Coité do Nóia", "Colônia Leopoldina",
                "Coqueiro Seco", "Coruripe", "Craíbas",

                "Delmiro Gouveia", "Dois Riachos",

                "Estrela de Alagoas",

                "Feira Grande", "Feliz Deserto", "Flexeiras",

                "Girau do Ponciano",

                "Ibateguara", "Igaci", "Igreja Nova", "Inhapi",

                "Jacaré dos Homens", "Jacuípe", "Japaratinga", "Jaramataia",
                "Jequiá da Praia", "Joaquim Gomes", "Jundiá", "Junqueiro",

                "Lagoa da Canoa", "Limoeiro de Anadia",

                "Maceió", "Major Isidoro", "Mar Vermelho", "Maragogi", "Maravilha", "Marechal Deodoro",
                "Maribondo", "Mata Grande", "Matriz de Camaragibe", "Messias", "Minador do Negrão",
                "Monteirópolis", "Murici",

                "Novo Lino",

                "Olho dÁgua das Flores", "Olho dÁgua do Casado",
                "Olho dÁgua Grande", "Olivença", "Ouro Branco",

                "Palestina", "Palmeira dos Índios", "Pão de Açúcar", "Pariconha", "Paripueira",
                "Passo de Camaragibe", "Paulo Jacinto", "Penedo", "Piaçabuçu", "Pilar",
                "Pindoba", "Piranhas", "Poço das Trincheiras", "Porto Calvo", "Porto de Pedras",
                "Porto Real do Colégio",

                "Quebrangulo",

                "Rio Largo", "Roteiro",

                "Santa Luzia do Norte", "Santana do Ipanema", "Santana do Mundaú", "São Brás",
                "São José da Laje", "São José da Tapera", "São Luís do Quitunde", "São Miguel dos Campos",
                "São Miguel dos Milagres", "São Sebastião", "Satuba", "Senador Rui Palmeira",

                "Tanque dArca", "Taquarana", "Teotônio Vilela", "Traipu",

                "União dos Palmares",

                "Viçosa"
            };

            cb.Items.AddRange(citiesOfBrazil);

            return cb;
        }

        /// <summary>
        /// Retorna em um componente ComboBox a lista de cidades pertencentes ao estado do Amapá.
        /// </summary>
        /// <param name="cb">Componente ComboBox que receberá o retorno das cidades.</param>
        public virtual ComboBox Amapá(ComboBox cb)
        {
            citiesOfBrazil = new string[]
            {
                "Amapá",

                "Calçoene", "Cutias",

                "Ferreira Gomes",

                "Itaubal",

                "Laranjal do Jari",

                "Macapá", "Mazagão",

                "Oiapoque",

                "Pedra Branca do Amapari", "Porto Grande", "Pracuúba",

                "Santana", "Serra do Navio",

                "Tartarugalzinho",

                "Vitória do Jari"
            };

            cb.Items.AddRange(citiesOfBrazil);

            return cb;
        }

        /// <summary>
        /// Retorna em um componente ComboBox a lista de cidades pertencentes ao estado do Amazonas.
        /// </summary>
        /// <param name="cb">Componente ComboBox que receberá o retorno das cidades.</param>
        public virtual ComboBox Amazonas(ComboBox cb)
        {
            citiesOfBrazil = new string[]
            {
                "Alvarães", "Amaturá", "Anamã", "Anori",
                "Apuí", "Atalaia do Norte", "Autazes",

                "Barcelos", "Barreirinha", "Benjamin Constant", "Beruri",
                "Boa Vista do Ramos", "Boca do Acre", "Borba",

                "Caapiranga", "Canutama", "Carauari",
                "Careiro", "Careiro da Várzea", "Coari", "Codajás",

                "Eirunepé", "Envira",

                "Fonte Boa",

                "Guajará",

                "Humaitá",

                "Ipixuna", "Iranduba", "Itacoatiara", "Itamarati", "Itapiranga",

                "Japurá", "Juruá", "Jutaí",

                "Lábrea",

                "Manacapuru", "Manaquiri", "Manaus", "Manicoré", "Maraã", "Maués",

                "Nhamundá", "Nova Olinda do Norte", "Novo Airão", "Novo Aripuanã",

                "Parintins", "Pauini", "Presidente Figueiredo",

                "Rio Preto da Eva",

                "Santa Isabel do Rio Negro", "Santo Antônio do Içá", "São Gabriel da Cachoeira",
                "São Paulo de Olivença", "São Sebastião do Uatumã", "Silves",

                "Tabatinga", "Tapauá", "Tefé", "Tonantins",

                "Uarini", "Urucará", "Urucurituba"
            };

            cb.Items.AddRange(citiesOfBrazil);

            return cb;
        }
    }
}
