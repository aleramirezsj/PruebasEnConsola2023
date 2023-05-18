using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSplit.Enums;

namespace ProyectoSplit.Class
{
    public class Split
    {
        public int Dirección { get; set; }
        public bool Balanceo { get; set; }
        public int Temperatura { get; set; }
        public int Consumo { get; set; }
        public bool Encendido { get; set; }
        public string Tamaño { get; set; }
        public ModoOperacionEnum ModoOperacion { get; set; }
        public string Marca { get; set; }
        public int Frigorias { get; set; }

        public Split(int dirección, bool balanceo, int temperatura, int consumo, bool encendido, string tamaño, ModoOperacionEnum modoOperacion, string marca, int frigorias)
        {
            this.Dirección = dirección;
            this.Balanceo = balanceo;
            this.Temperatura = temperatura;
            this.Consumo = consumo;
            this.Encendido = encendido;
            this.Tamaño = tamaño;
            this.ModoOperacion = modoOperacion;
            this.Marca = marca;
            this.Frigorias = frigorias;
        }

        public Split(int consumo, string tamaño, string marca, int frigorias)
        {
            this.Consumo = consumo;
            this.Tamaño = tamaño;
            this.Marca = marca;
            this.Frigorias = frigorias;
        }

        public Split()
        {
            
        }
        public void Encender()
        {
            this.Dirección = 1;
            this.Temperatura = 24;
            this.ModoOperacion = ModoOperacionEnum.Frio;
            this.Encendido = true;
        }
        public void Apagar()
        {
            this.Dirección = 0;
            this.Temperatura = 0;
            this.Encendido = false;
        }
        public string Status()
        {
            string retorno = "====================================================="+Environment.NewLine;
            retorno += $"Split {this.Marca} {this.Frigorias} frigorias {Environment.NewLine}";
            string vEstado = this.Encendido ? "Encendido" : "Apagado";
            retorno += $"Estado: {vEstado} Modo:{this.ModoOperacion} {Environment.NewLine}";
            string vBalanceo = this.Balanceo ? "Encendido" : "Apagado";
            retorno += $"Temperatura: {this.Temperatura} Balanceo: {vBalanceo} {Environment.NewLine}";
            retorno += "=====================================================";
            return retorno ;
        }
        public override string ToString()
        {
            return $"Split {this.Marca} {this.Tamaño} consumo: {this.Consumo} watts {this.Frigorias} frigorias";
        }

        public bool CambiarTemperatura(int temperatura)
        {
            this.Temperatura= temperatura;
            return this.Temperatura == temperatura;
        }

    }
}
