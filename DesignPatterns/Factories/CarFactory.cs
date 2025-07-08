using DesignPatterns.Models;

namespace DesignPatterns.Factories
{
    /// <summary>
    /// Clase abstracta que define el patrón Factory Method para la creación de vehículos.
    /// Implementa el patrón Factory Method permitiendo que las subclases decidan 
    /// qué tipo específico de vehículo crear.
    /// </summary>
    public abstract class CarFactory
    {
        /// <summary>
        /// Método abstracto que debe ser implementado por las clases derivadas
        /// para crear instancias específicas de vehículos.
        /// </summary>
        /// <returns>Una instancia de Vehicle creada por la factory concreta</returns>
        public abstract Vehicle Create();
    }
}
