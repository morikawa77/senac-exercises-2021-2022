using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04_PilaresOO
{
    class Veiculo
    {
        public string tipoCombustivel { get; set; }
        public string setas { get; set; }
        public string tipoBancos { get; set; }
        public int potencia { get; set; }
        public bool isCambioAutomatico { get; set; }
        public float aroRodas { get; set; }
        public int qtdLugares { get; set; }
        public string cor { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public float peso { get; set; }
        public int qtdRodas { get; set; }

        public Veiculo() { }

        public Veiculo(string tipoCombustivel, string setas, string tipoBancos, int potencia, bool isCambioAutomatico, float aroRodas, int qtdLugares, string cor, string marca, string modelo, float peso)
        {
            this.tipoCombustivel = tipoCombustivel;
            this.setas = setas;
            this.tipoBancos = tipoBancos;
            this.potencia = potencia;
            this.isCambioAutomatico = isCambioAutomatico;
            this.aroRodas = aroRodas;
            this.qtdLugares = qtdLugares;
            this.cor = cor;
            this.marca = marca;
            this.modelo = modelo;
            this.peso = peso;
        }

        public Veiculo(bool isCambioAutomatico, int qtdLugares)
        {
            this.isCambioAutomatico = isCambioAutomatico;
            this.qtdLugares = qtdLugares;
        }

        public void MoverParaFrente() { }
        public void MoverParaTras() { }
        public void Estacionar() { }
        public void Frear() { }
    }
}
