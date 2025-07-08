using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    /// <summary>
    /// Clase que representa un automóvil específico.
    /// Hereda de Vehicle y define características específicas de un carro.
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Número de llantas específico para un carro (siempre 4).
        /// Sobrescribe la propiedad virtual de la clase base.
        /// </summary>
        public override int Tires { get => 4; }

        /// <summary>
        /// Constructor para crear una instancia de Car.
        /// </summary>
        /// <param name="color">Color del carro</param>
        /// <param name="brand">Marca del carro</param>
        /// <param name="model">Modelo del carro</param>
        /// <param name="year">Año de fabricación del carro</param>
        public Car(string color, string brand, string model, int year) : base(color, brand, model)
        {
            // Nota: El parámetro year se recibe pero no se almacena en la clase base
            // Esto podría ser un problema de diseño que requiere atención
        }
    }
}
