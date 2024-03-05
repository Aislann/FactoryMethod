using FactoryMethod.ConcretCreator;
using FactoryMethod.Creator;
using FactoryMethod.Product;

CartaoFactory cartaoFactory = null;
Console.WriteLine("Digite o tipo de Cartão para o cliente: ");
string console = Console.ReadLine();

switch (console.ToLower())
{
    case "black":
        cartaoFactory = new BlackFactory(10000,0);
        break;
    case "titanium":
        cartaoFactory = new TitaniumFactory(50000, 700);
        break;
    case "platinum":
        cartaoFactory = new PlatinumFactory(100000, 2000);
        break;
    default: 
        break;
}

CartaoCredito cartaoCredito = cartaoFactory.BuscarCartaoCredito();
Console.WriteLine("\nOs detalhes do seu cartão estão abaixo: ");
Console.WriteLine("Tipo de Cartão: {0}\nCrédito limite: {1}\nCobrança anual: {2}", cartaoCredito.TipoCartao,  cartaoCredito.LimiteCartao, cartaoCredito.Anuidade);
Console.ReadKey();  