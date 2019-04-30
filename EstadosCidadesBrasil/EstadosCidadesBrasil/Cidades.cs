﻿using System;
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

        /// <summary>
        /// Retorna em um componente ComboBox a lista de cidades pertencentes ao estado da Bahia.
        /// </summary>
        /// <param name="cb">Componente ComboBox que receberá o retorno das cidades.</param>
        public virtual ComboBox Bahia(ComboBox cb)
        {
            citiesOfBrazil = new string[]
            {
                "Abaíra", "Abaré", "Acajutiba", "Adustina", "Água Fria", "Aiquara",
                "Alagoinhas", "Alcobaça", "Almadina", "Amargosa", "Amélia Rodrigues",
                "América Dourada", "Anagé", "Andaraí", "Andorinha", "Angical", "Anguera",
                "Antas", "Antônio Cardoso", "Antônio Gonçalves", "Aporá", "Apuarema",
                "Araças", "Aracatu", "Araci", "Aramari", "Arataca", "Aratuípe", "Aurelino Leal",

                "Baianópolis", "Baixa Grande", "Banzaê", "Barra", "Barra da Estiva", "Barra do Choça",
                "Barra do Mendes", "Barra do Rocha", "Barreiras", "Barro Alto", "Barro Preto", "Barrocas",
                "Belmonte", "Belo Campo", "Biritinga", "Boa Nova", "Boa Vista do Tupim", "Bom Jesus da Lapa",
                "Bom Jesus da Serra", "Boninal", "Bonito", "Boquira", "Botuporã", "Brejões", "Brejolândia",
                "Brotas de Macaúbas", "Brumado", "Buerarema", "Buritirama",

                "Caatiba", "Cabaceiras do Paraguaçu", "Cachoeira", "Caculé", "Caém", "Caetanos", "Caetité",
                "Cafarnaum", "Cairu", "Caldeirão Grande", "Camacan","Camaçari", "Camamu", "Campo Alegre de Lourdes",
                "Campo Formoso", "Canápolis", "Canarana", "Canavieiras", "Candeal", "Candeias", "Candiba", "Cândido Sales",
                "Cansanção", "Canudos", "Capela do Alto Alegre", "Capim Grosso", "Caraíbas", "Caravelas", "Cardeal da Silva",
                "Carinhanha", "Casa Nova", "Castro Alves", "Catolândia", "Catu", "Caturama", "Central", "Chorrochó", "Cícero Dantas",
                "Cipó", "Coaraci", "Cocos", "Conceição da Feira", "Conceição do Almeida", "Conceição do Coité", "Conceição do Jacuípe",
                "Conde", "Condeúba", "Contendas do Sincorá", "Coração de Maria", "Cordeiros", "Coribe", "Coronel João Sá", "Correntina",
                "Cotegipe", "Cravolândia", "Crisópolis", "Cristópolis", "Cruz das Almas", "Curaçá",

                "Dário Meira", "Dias dÁvila", "Dom Basílio", "Dom Macedo Costa",

                "Elísio Medrado", "Encruzilhada", "Entre Rios", "Érico Cardoso",
                "Esplanada", "Euclides da Cunha", "Eunápolis",

                "Fátima", "Feira da Mata", "Feira de Santana", "Filadélfia", "Firmino Alves",
                "Floresta Azul", "Formosa do Rio Preto",

                "Gandu", "Gavião", "Gentio do Ouro", "Glória", "Gongogi",
                "Governador Mangabeira", "Guajeru", "Guanambi", "Guaratinga",

                "Heliópolis",

                "Iaçu", "Ibiassucê", "Ibicaraí", "Ibicoara", "Ibicuí", "Ibipeba", "Ibipitanga", "Ibiquera",
                "Ibirapitanga", "Ibirapuã", "Ibirataia", "Ibitiara", "Ibititá", "Ibotirama", "Ichu",
                "Igaporã", "Igrapiúna", "Iguaí", "Ilhéus", "Inhambupe", "Ipecaetá", "Ipiaú", "Ipirá",
                "Ipupiara", "Irajuba", "Iramaia", "Iraquara", "Irará", "Irecê", "Itabela", "Itaberaba",
                "Itabuna", "Itacaré", "Itaeté", "Itagi", "Itagibá", "Itagimirim", "Itaguaçu da Bahia",
                "Itaju do Colônia", "Itajuípe", "Itamaraju", "Itamari", "Itambé", "Itanagra", "Itanhém",
                "Itaparica", "Itapé", "Itapebi", "Itapetinga", "Itapicuru", "Itapitanga", "Itaquara",
                "Itarantim", "Itatim", "Itiruçu", "Itiúba", "Itororó", "Ituaçu", "Ituberá", "Iuiú",

                "Jaborandi", "Jacaraci", "Jacobina", "Jaguaquara", "Jaguarari", "Jaguaripe",
                "Jandaíra", "Jequié", "Jeremoabo", "Jiquiriçá", "Jitaúna", "João Dourado",
                "Juazeiro", "Jucuruçu", "Jussara", "Jussari", "Jussiape",


                "Lafaiete Coutinho", "Lagoa Real", "Laje", "Lajedão", "Lajedinho",
                "Lajedo do Tabocal", "Lamarão", "Lapão", "Lauro de Freitas", "Lençóis",
                "Licínio de Almeida", "Livramento de Nossa Senhora", "Luís Eduardo Magalhães",

                "Macajuba", "Macarani", "Macaúbas", "Macururé", "Madre de Deus", "Maetinga", "Maiquinique",
                "Mairi", "Malhada", "Malhada de Pedras", "Manoel Vitorino", "Mansidão", "Maracás",
                "Maragogipe", "Maraú", "Marcionílio Souza", "Mascote", "Mata de São João", "Matina",
                "Medeiros Neto", "Miguel Calmon", "Milagres", "Mirangaba", "Mirante", "Monte Santo",
                "Morpará", "Morro do Chapéu", "Mortugaba", "Mucugê", "Mucuri", "Mulungu do Morro",
                "Mundo Novo", "Muniz Ferreira", "Muquém de São Francisco", "Muritiba", "Mutuípe",

                "Nazaré", "Nilo Peçanha", "Nordestina", "Nova Canaã", "Nova Fátima",
                "Nova Ibiá", "Nova Itarana", "Nova Redenção", "Nova Soure",
                "Nova Viçosa", "Novo Horizonte", "Novo Triunfo",

                "Olindina", "Oliveira dos Brejinhos", "Ouriçangas", "Ourolândia",

                "Palmas de Monte Alto", "Palmeiras", "Paramirim", "Paratinga", "Paripiranga",
                "Pau Brasil", "Paulo Afonso", "Pé de Serra", "Pedrão", "Pedro Alexandre",
                "Piatã", "Pilão Arcado", "Pindaí", "Pindobaçu", "Pintadas", "Piraí do Norte",
                "Piripá", "Piritiba", "Planaltino", "Planalto", "Poções", "Pojuca", "Ponto Novo",
                "Porto Seguro", "Potiraguá", "Prado", "Presidente Dutra", "Presidente Jânio Quadros",
                "Presidente Tancredo Neves",

                "Queimadas", "Quijingue", "Quixabeira",

                "Rafael Jambeiro", "Remanso", "Retirolândia", "Riachão das Neves", "Riachão do Jacuípe",
                "Riacho de Santana", "Ribeira do Amparo", "Ribeira do Pombal", "Ribeirão do Largo",
                "Rio de Contas", "Rio do Antônio", "Rio do Pires", "Rio Real", "Rodelas", "Ruy Barbosa",

                "Salinas da Margarida", "Salvador", "Santa Bárbara", "Santa Brígida", "Santa Cruz Cabrália",
                "Santa Cruz da Vitória", "Santa Inês", "Santa Luzia", "Santa Maria da Vitória", "Santa Rita de Cássia",
                "Santa Teresinha", "Santaluz", "Santana", "Santanópolis", "Santo Amaro", "Santo Antônio de Jesus",
                "Santo Estêvão", "São Desidério", "São Domingos", "São Felipe", "São Félix", "São Félix do Coribe",
                "São Francisco do Conde", "São Gabriel", "São Gonçalo dos Campos", "São José da Vitória",
                "São José do Jacuípe", "São Miguel das Matas", "São Sebastião do Passé", "Sapeaçu",
                "Sátiro Dias", "Saubara", "Saúde", "Seabra", "Sebastião Laranjeiras", "Senhor do Bonfim", "Sento Sé",
                "Serra do Ramalho", "Serra Dourada", "Serra Preta", "Serrinha", "Serrolândia", "Simões Filho",
                "Sítio do Mato", "Sítio do Quinto", "Sobradinho", "Souto Soares",

                "Tabocas do Brejo Velho", "Tanhaçu", "Tanque Novo", "Tanquinho", "Taperoá",
                "Tapiramutá", "Teixeira de Freitas", "Teodoro Sampaio", "Teofilândia",
                "Teolândia", "Terra Nova", "Tremedal", "Tucano",

                "Uauá", "Ubaíra", "Ubaitaba", "Ubatã", "Uibaí",
                "Umburanas","Una", "Urandi", "Uruçuca", "Utinga",

                "Valença", "Valente", "Várzea da Roça", "Várzea do Poço", "Várzea Nova",
                "Varzedo", "Vera Cruz", "Vereda", "Vitória da Conquista",

                "Wagner", "Wanderley", "Wenceslau Guimarães",

                "Xique-Xique"
            };

            cb.Items.AddRange(citiesOfBrazil);

            return cb;
        }

        /// <summary>
        /// Retorna em um componente ComboBox a lista de cidades pertencentes ao estado de Alagoas.
        /// </summary>
        /// <param name="cb">Componente ComboBox que receberá o retorno das cidades.</param>
        public virtual ComboBox Ceará(ComboBox cb)
        {
            citiesOfBrazil = new string[]
            {
                "Abaiara", "Acarape", "Acaraú", "Acopiara", "Aiuaba",
                "Alcântaras", "Altaneira", "Alto Santo", "Amontada", "Antonina do Norte",
                "Apuiarés", "Aquiraz", "Aracati", "Aracoia", "Ararendá",
                "Araripe", "Aratuba", "Arneiro", "Assaré", "Aurora",

                "Baixio", "Banabuiú", "Barbalha", "Barreira", "Barro", "Barroquinha",
                "Baturité", "Beberibe", "Bela Cruz", "Boa Viagem", "Brejo Santo",

                "Camocim", "Campos Sales", "Canindé", "Capistrano", "Caridade",
                "Cariré", "Caririaçu", "Cariús", "Carnaubal", "Cascavel",
                "Catarina", "Catunda", "Caucaia", "Cedro", "Chaval",
                "Choró", "Chorozinho", "Coreaú", "Crateús", "Crato", "Croatá", "Cruz",

                "Deputado Irapuan Pinheiro",

                "Ererê", "Eusébio",

                "Farias Brito", "Forquilha", "Fortaleza", "Fortim", "Frecheirinha",

                "General Sampaio", "Graça", "Granja", "Granjeiro", "Groaíras",
                "Guaiúba", "Guaraciaba do Norte", "Guaramiranga",

                "Hidrolândia", "Horizonte",

                "Ibaretama", "Ibiapina", "Ibicuitinga", "Icapuí", "Icó", "Iguatu",
                "Independência", "Ipaporanga", "Ipaumirim", "Ipu", "Ipueiras", "Iracema", "Irauçuba",
                "Itaiçaba", "Itaitinga", "Itapagé", "Itapipoca", "Itapiúna", "Itarema", "Itatira",

                "Jaguaretama", "Jaguaribara", "Jaguaribe", "Jaguaruana", "Jardim",
                "Jati", "Jijoca de Jericoacoara", "Juazeiro do Norte", "Jucás",

                "Lavras da Mangabeira", "Limoeiro do Norte",

                "Madalena", "Maracanaú", "Maranguape", "Marco", "Martinópole", "Massapê",
                "Mauriti", "Meruoca", "Milagres", "Milhã", "Miraíma", "Missão Velha", "Mombaça",
                "Monsenhor Tabosa", "Morada Nova", "Moraújo", "Morrinhos", "Mucambo", "Mulungu",

                "Nova Olinda", "Nova Russas", "Novo Oriente",

                "Ocara", "Orós",

                "Pacajus", "Pacatuba", "Pacoti", "Pacujá", "Palhano", "Palmácia", "Paracuru",
                "Paraipaba", "Parambu", "Paramoti", "Pedra Branca", "Penaforte", "Pentecoste",
                "Pereiro", "Pindoretama", "Piquet Carneiro", "Pires Ferreira", "Poranga",
                "Porteiras", "Potengi", "Potiretama",

                "Quiterianópolis", "Quixadá", "Quixelô", "Quixeramobim", "Quixeré",

                "Redenção", "Reriutaba", "Russas",

                "Saboeiro", "Salitre", "Santa Quitéria", "Santana do Acaraú", "Santana do Cariri",
                "São Benedito", "São Gonçalo do Amarante", "São João do Jaguaribe", "São Luís do Curu",
                "Senador Pompeu", "Senador Sá", "Sobral", "Solonópole",

                "Tabuleiro do Norte", "Tamboril", "Tarrafas", "Tauá", "Tejuçuoca",
                "Tianguá", "Trairi", "Tururu",

                "Ubajara", "Umari", "Umirim", "Uruburetama", "Uruoca",

                "Varjota", "Várzea Alegre", "Viçosa do Ceará"
            };

            cb.Items.AddRange(citiesOfBrazil);

            return cb;
        }

        /// <summary>
        /// Retorna em um componente ComboBox a lista de cidades pertencentes ao estado de Distrito Federal.
        /// </summary>
        /// <param name="cb">Componente ComboBox que receberá o retorno das cidades.</param>
        public virtual ComboBox DistritoFederal(ComboBox cb)
        {
            citiesOfBrazil = new string[]
            {
               "Águas Claras",

               "Brasília", "Brazlândia",

               "Candangolândia", "Ceilândia", "Cruzeiro",

               "Gama", "Guará",

               "Itapoã",

               "Núcleo Bandeirante",

               "Paranoá", "Planaltina",

               "Recanto das Emas", "Riacho Fundo",

               "Samambaia", "Santa Maria", "São Sebastião", "Sobradinho",

               "Taguatinga",

               "Varjão"
            };

            return cb;
        }

        /// <summary>
        /// Retorna em um componente ComboBox a lista de cidades pertencentes ao estado do Espírito Santo.
        /// </summary>
        /// <param name="cb">Componente ComboBox que receberá o retorno das cidades.</param>
        public virtual ComboBox EspiritoSanto(ComboBox cb)
        {
            citiesOfBrazil = new string[]
            {
                "Afonso Cláudio", "Água Doce do Norte", "Águia Branca", "Alegre",
                "Alfredo Chaves", "Alto Rio Novo", "Anchieta", "Apiacá",
                "Aracruz", "Atilio Vivacqua",

                "Baixo Guandu", "Barra de São Francisco", "Boa Esperança",
                "Bom Jesus do Norte", "Brejetuba",

                "Cachoeiro de Itapemirim", "Cariacica", "Castelo",
                "Colatina", "Conceição da Barra", "Conceição do Castelo",

                "Divino de São Lourenço", "Domingos Martins", "Dores do Rio Preto",

                "Ecoporanga",

                "Fundão",

                "Governador Lindenberg", "Guaçuí", "Guarapari",

                "Ibatiba", "Ibiraçu", "Ibitirama", "Iconha", "Irupi",
                "Itaguaçu", "Itapemirim", "Itarana", "Iúna",

                "Jaguaré", "Jerônimo Monteiro", "João Neiva",

                "Laranja da Terra", "Linhares",

                "Mantenópolis", "Marataízes", "Marechal Floriano", "Marilândia",
                "Mimoso do Sul", "Montanha", "Mucurici", "Muniz Freire", "Muqui",

                "Nova Venécia",

                "Pancas", "Pedro Canário", "Pinheiros", "Piúma", "Ponto Belo", "Presidente Kennedy",

                "Rio Bananal", "Rio Novo do Sul",

                "Santa Leopoldina", "Santa Maria de Jetibá", "Santa Teresa",
                "São Domingos do Norte", "São Gabriel da Palha", "São José do Calçado",
                "São Mateus", "São Roque do Canaã", "Serra", "Sooretama",

                "Vargem Alta", "Venda Nova do Imigrante", "Viana", "Vila Pavão",
                "Vila Valério", "Vila Velha", "Vitória"
            };

            return cb;
        }
    }
}
