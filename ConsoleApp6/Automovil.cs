using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class programa
    {
        static void Main(string[] args)
        {
            Automovil carro = new Automovil
            {
                Marca = "McLaren",
                Placa = "XYZ123",
                Modelo = "Formula1",
                Color = "Negro",
                CapacidadTanqueCombustible = 15,
                RendimientoCombustible = 30
            };

            // Intenta conducir 100 km
            if (carro.PuedeConducir(100))
            {
                carro.Conducir(100);
            }
            else
            {
                Console.WriteLine("No es posible conducir la distancia especificada con el combustible actual.");
                // Reabastecer antes de conducir
                carro.ReabastecerCombustible(10);
                carro.Conducir(100);
            }
        }
    }
}
