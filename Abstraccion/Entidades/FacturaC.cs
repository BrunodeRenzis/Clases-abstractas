using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class FacturaC:Factura
    {
        public FacturaC() : base("Natalia Natalia","20-222222222-2")
        {

        }
        public FacturaC(string nombreCliente,string cuitEmisor):base(nombreCliente,cuitEmisor)
        {
            this.nombreCliente = nombreCliente;
        }

        public override string RetornarDatosCompletos()
        {
            return base.RetornarDatosCliente();
        }

        public override int NroFactura { get { return base.nroFactura; } set { base.nroFactura = value; } }

        public override string NombreYCuit => throw new NotImplementedException();

        public override string RetornarNroCuit()
        {
            return "Factura C Cuit: "+this.cuitEmisor;
        }

        public override string RetornarNombreYCuit()
        {
            return this.NombreYCuit;
        }
    }
}
