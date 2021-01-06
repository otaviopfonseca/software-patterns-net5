using FabricaMoveis.Moveis.MoveisBase;

namespace FabricaMoveis.Moveis.MoveisModernos
{
    public class SofaModerno : ISofa
    {
        public int NumeroLugares { get; init; }

        public SofaModerno(int numeroLugares)
        {
            NumeroLugares = numeroLugares;
        }

        public string Imprimir()
        {
            return $"Isto é um sofá de {NumeroLugares} lugares";
        }
    }
}