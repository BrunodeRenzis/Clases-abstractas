using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class FacturaABaja:FacturaA
    {
        
        public FacturaABaja(string nombre, float importeSinIva, string cuit ):base(nombre,importeSinIva,cuit)
        {

        }

        public override string RetornarDatosCompletos()
        {
            return base.RetornarDatosCompletos();
        }

        public override DateTime DameFechaFactura()
        {
            return base.DameFechaFactura();
        }
    }
}
