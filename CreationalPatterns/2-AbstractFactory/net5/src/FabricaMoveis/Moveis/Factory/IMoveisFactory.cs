using FabricaMoveis.Moveis.Factory;
using FabricaMoveis.Moveis.MoveisBase;

namespace FabricaMoveis.Moveis.Factory
{
    public interface IMoveisFactory
    {
        ICadeira CriarCadeira();
        IMesa CriarMesa();
        ISofa CriarSofa();

    }
}