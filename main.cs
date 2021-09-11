using System;

class main
{
    public static void Main(string[] args)
    {
        Carro meuCarroDePasseio = new Carro("GTB", "Ferrari", 2017, 2000000, 90, 3);
        Carro MeuCarroDeBalada = new Carro("Palio", "Fiat", 2002, 40000, 43, 75000, 25, 10,30000);

        meuCarroDePasseio.percorrerDistancia(70);
        Console.WriteLine("Km atual: {0}",meuCarroDePasseio.getKmRodados());
        Console.WriteLine("Capacidade atual do tanque: {0}",meuCarroDePasseio.getTanqueAtual());

        double abastecidos = MeuCarroDeBalada.encherTanque(6);
        Console.WriteLine("Foram abastecidos R$ {0}", abastecidos);
    }
}