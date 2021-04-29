using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class FacturaB : Factura
    {

        public FacturaB(string nombreCliente,string cuitEmisor):base(nombreCliente,cuitEmisor)
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
            return base.RetornarNroCuit();//Llamando a la funcionalidad del base. Esto aparece x defecto.
            //return this.cuitEmisor;
            //return this.RetornarNroCuit(); Llamada ciclica
        }

        public override string RetornarNombreYCuit()
        {
            return this.NombreYCuit;
        }
    }
 
}
