using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public partial class Automovil
    {
        public string Marca { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public double CapacidadTanqueCombustible { get; set; }
        public double NivelCombustible { get; set; } = 0;
        public double RendimientoCombustible { get; set; }

        public void Conducir(int distancia)
        {
            double combustibleNecesario = distancia / RendimientoCombustible;
            if (NivelCombustible >= combustibleNecesario)
            {
                NivelCombustible -= combustibleNecesario;
                Console.WriteLine($"El carro ha conducido {distancia} km y le queda {NivelCombustible} galones de combustible.");
            }
            else
            {
                Console.WriteLine("No hay suficiente combustible para realizar el viaje.");
            }
        }

        public void ReabastecerCombustible(double cantidad)
        {
            if (cantidad + NivelCombustible <= CapacidadTanqueCombustible)
            {
                NivelCombustible += cantidad;
                Console.WriteLine($"Se ha reabastecido el tanque. Nivel de combustible actual: {NivelCombustible} galones.");
            }
            else
            {
                Console.WriteLine("La cantidad excede la capacidad máxima del tanque.");
            }
        }

        public bool PuedeConducir(int distancia)
        {
            return (distancia / RendimientoCombustible) <= NivelCombustible;
        }
    }
}
