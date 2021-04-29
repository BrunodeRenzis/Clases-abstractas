using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Factura:Documento
    {
        protected float importeFinal;
        protected int nroFactura;

        public Factura(string nombreCliente,string cuitEmisor)
        {
            this.nombreCliente = nombreCliente;
            this.cuitEmisor = cuitEmisor;
        }

        public abstract int NroFactura
        {
            get;
            set;
        }
        public string NombreCliente
        {
            get { return this.nombreCliente; }
            set { this.nombreCliente = value; }
        }

        public string CuitEmisor
        {
            get { return this.cuitEmisor; }
            set { this.cuitEmisor = value; }
        }

        public float ImporteFinal
        {
            get { return this.importeFinal; }
            set { this.importeFinal = value; }
        }
        public string RetornarDatosCliente()
        {
            return this.nombreCliente;
        }

        public abstract string RetornarDatosCompletos();

        public virtual string RetornarNroCuit()
        {
            return this.cuitEmisor;
        }

    }
}