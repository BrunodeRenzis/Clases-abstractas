using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Remito : Documento
    {
        public override string NombreYCuit
        {
            get { return this.nombreCliente + this.cuitEmisor; }
        }

        public override string RetornarNombreYCuit()
        {
            return this.NombreYCuit;
        }
    }
}
