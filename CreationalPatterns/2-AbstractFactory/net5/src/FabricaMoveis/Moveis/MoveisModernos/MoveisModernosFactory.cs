using FabricaMoveis.Moveis.Factory;
using FabricaMoveis.Moveis.MoveisBase;

namespace FabricaMoveis.Moveis.MoveisModernos
{
    public class MoveisModernosFactory : IMoveisFactory
    {
        public ICadeira CriarCadeira()
        {
            return new CadeiraModerna();
        }

        public IMesa CriarMesa()
        {
            return new MesaModerna();
        }

        public ISofa CriarSofa()
        {
            return new SofaModerno();
        }
    }
}