using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Documento
    {
        protected string nombreCliente;
        protected string cuitEmisor;

        public abstract string RetornarNombreYCuit();

        public abstract string NombreYCuit
        {
            get;
           
        }
    }
}
