using System;

namespace Dominio
{
    public class Veiculo
    {
        public Veiculo(string marca, string modelo, int ano, double quilometragem)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Quilometragem = quilometragem;
        }

        public int VeiculoId { get; private set; }
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public int Ano { get; private set; }
        public double Quilometragem { get; private set; }


        public void AtualizarVeiculo(string marca, string modelo, int ano, double quilometragem)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;
            this.Quilometragem = quilometragem;
    }
    }

   
}
