using FabricaMoveis.Moveis.MoveisBase;

namespace FabricaMoveis.Moveis.MoveisVintage
{
    public class SofaVintage : ISofa
    {
        public int NumeroLugares { get; init; }

        public SofaVintage(int numeroLugares)
        {
            NumeroLugares = numeroLugares;
        }

        public string Imprimir()
        {
            return $"Isto é um sofá vintage de {NumeroLugares} lugares";
        }
    }
}
