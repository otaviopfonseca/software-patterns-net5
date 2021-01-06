using FabricaMoveis.Moveis.MoveisBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaMoveis.Moveis.MoveisVintage
{
    public class CadeiraVintage : ICadeira
    {
        public string Imprimir()
        {
            return "Isto é uma cadeira vintage";
        }
    }
}
