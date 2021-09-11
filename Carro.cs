using System;

class Carro
{
    private string modelo, marca;
    private int anoFabricacao;
    private double valorNovo, valorAtual, capacidadeTanque, kmRodados, tanqueAtual, autonomiaLitro;

    public Carro(string modelo, string marca, int anoFabricacao, double valorNovo, double capacidadeTanque, double autonomiaLitro)
    {
        this.modelo = modelo;
        this.marca = marca;
        this.anoFabricacao = anoFabricacao;
        this.valorNovo = valorNovo;
        this.valorAtual = this.valorNovo;
        this.kmRodados = 0.0;
        this.capacidadeTanque = capacidadeTanque;
        this.tanqueAtual = this.capacidadeTanque;
        this.autonomiaLitro = autonomiaLitro;
    }

    public Carro(string modelo, string marca, int anoFabricacao, double valorNovo, double capacidadeTanque, double kmRodados, 
        double tanqueAtual, double autonomiaLitro,double valorAtual)
    {
        this.modelo = modelo;
        this.marca = marca;
        this.anoFabricacao = anoFabricacao;
        this.valorNovo = valorNovo;
        this.valorAtual = valorAtual;
        this.kmRodados = kmRodados;
        this.capacidadeTanque = capacidadeTanque;
        this.tanqueAtual = tanqueAtual;
        this.autonomiaLitro = autonomiaLitro;
    }

    public bool percorrerDistancia(int distancia)
    {
        double kmPercorrer = this.tanqueAtual * this.autonomiaLitro;
        if (kmPercorrer > distancia)
        {
            this.kmRodados += distancia;
            this.tanqueAtual -= distancia / this.autonomiaLitro;
            return true;
        }
        else
        {
            Console.WriteLine("Você não possui combustível suficiente para a viagem!");
        }
        return false;
    }

    public double encherTanque(double precoGasolina)
    {   
        double abastecido = (this.capacidadeTanque - this.tanqueAtual) * precoGasolina;
        this.tanqueAtual = this.capacidadeTanque;
        return abastecido;
    }

    public void atualizarValorCarro(int anoAtual)
    {
        this.valorAtual = valorNovo - (anoAtual - anoFabricacao) * 2.05;
    }

    public string getModelo()
    {
        return this.modelo;
    }
    public string getMarca()
    {
        return this.marca;
    }
    public int getAnoFabricacao()
    {
        return this.anoFabricacao;
    }
    public double getValorNovo()
    {
        return this.valorNovo;
    }
    public double getValorAtual()
    {
        return this.valorAtual;
    }
    public double getCapacidadeTanque()
    {
        return this.capacidadeTanque;
    }
    public double getKmRodados()
    {
        return this.kmRodados;
    }
    public double getTanqueAtual()
    {
        return this.tanqueAtual;
    }
    public double getAutonomiaLitro()
    {
        return this.autonomiaLitro;
    }
}