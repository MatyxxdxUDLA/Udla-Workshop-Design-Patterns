using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    /// <summary>
    /// Clase que representa una motocicleta específica.
    /// Hereda de Vehicle y define características específicas de una motocicleta.
    /// </summary>
    public class Motocycle : Vehicle
    {
        /// <summary>
        /// Número de llantas específico para una motocicleta (siempre 2).
        /// Sobrescribe la propiedad virtual de la clase base.
        /// </summary>
        public override int Tires { get => 2; }

        /// <summary>
        /// Constructor para crear una instancia de Motocycle.
        /// </summary>
        /// <param name="color">Color de la motocicleta</param>
        /// <param name="brand">Marca de la motocicleta</param>
        /// <param name="model">Modelo de la motocicleta</param>
        public Motocycle(string color, string brand, string model) : base(color, brand, model, 5)
        {
            // Se establece un límite de combustible menor (5 galones) característico de motocicletas
        }
    }
}
