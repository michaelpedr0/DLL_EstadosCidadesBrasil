using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstadosCidadesBrasil
{
    public class EstadosCidadesBrasil
    {
        EstadosDoBrasil states;
        CidadesDosEstadosDoBrasil cities;  
        
        public ComboBox EstadosDoBrasil (ComboBox estadosBrasil)
        {
            states = new EstadosDoBrasil();

            states.EstadosBrasil(estadosBrasil);

            return estadosBrasil;
        }
    }

    public partial class CidadesDosEstadosDoBrasil : Cidades
    {
        public override ComboBox Acre(ComboBox cb)
        {
            return base.Acre(cb);
        }

        public override ComboBox Alagoas(ComboBox cb)
        {
            return base.Alagoas(cb);
        }

        public override ComboBox Amapá(ComboBox cb)
        {
            return base.Amapá(cb);
        }

        public override ComboBox Amazonas(ComboBox cb)
        {
            return base.Amazonas(cb);
        }

        public override ComboBox Bahia(ComboBox cb)
        {
            return base.Bahia(cb);
        }

        public override ComboBox Ceará(ComboBox cb)
        {
            return base.Ceará(cb);
        }

        public override ComboBox DistritoFederal(ComboBox cb)
        {
            return base.DistritoFederal(cb);
        }

        public override ComboBox EspíritoSanto(ComboBox cb)
        {
            return base.EspíritoSanto(cb);
        }

        public override ComboBox Goiás(ComboBox cb)
        {
            return base.Goiás(cb);
        }

        public override ComboBox Maranhão(ComboBox cb)
        {
            return base.Maranhão(cb);
        }

        public override ComboBox MatoGrosso(ComboBox cb)
        {
            return base.MatoGrosso(cb);
        }

        public override ComboBox MatoGrossoDoSul(ComboBox cb)
        {
            return base.MatoGrossoDoSul(cb);
        }
    }

    public partial class EstadosDoBrasil : Estados
    {
        public override ComboBox EstadosBrasil(ComboBox cb)
        {
            return base.EstadosBrasil(cb);
        }
    }
}
