using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class FacturaA : Factura
    {
        float importeSinIva;

        public FacturaA(string nombre,float importeSinIva, string cuitEmisor) : base(nombre,cuitEmisor)
        {
            this.importeSinIva = importeSinIva;
        }
        public float ImporteSinIva
        {
            get { return this.importeSinIva; }
            set { this.importeSinIva = value; }
        }

        public override int NroFactura { get { return base.nroFactura; } set { base.nroFactura = value; } }

        public override string NombreYCuit => throw new NotImplementedException();

        public override string RetornarDatosCompletos()
        {
            return base.RetornarDatosCliente();
        }

        public override string RetornarNroCuit()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Factura A" + base.RetornarNroCuit());
            return sb.ToString();
        }

        public virtual DateTime DameFechaFactura()
        {
            return DateTime.Now;
        }

        public override string RetornarNombreYCuit()
        {
            return this.NombreYCuit;
        }
    }
}

    









