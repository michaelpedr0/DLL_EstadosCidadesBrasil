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
    }

    public partial class EstadosDoBrasil : Estados
    {
        public override ComboBox EstadosBrasil(ComboBox cb)
        {
            return base.EstadosBrasil(cb);
        }
    }
}
