using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;

namespace DesignPatterns.Factories
{
    /// <summary>
    /// Factory concreta para la creación de vehículos Ford Mustang.
    /// Implementa el patrón Factory Method especializándose en la creación 
    /// de vehículos Mustang con características específicas.
    /// </summary>
    public class FordMustangFactory : CarFactory
    {
        /// <summary>
        /// Crea una instancia de Ford Mustang con configuración predeterminada.
        /// Utiliza el patrón Builder para construir el vehículo con propiedades específicas.
        /// </summary>
        /// <returns>Vehicle configurado como Ford Mustang amarillo del año 2023</returns>
        public override Vehicle Create()
        {
            return new CarModelBuilder()
                .SetColor("yellow")      // Color característico del Mustang
                .SetModel("Mustang")     // Modelo específico
                .SetYear(2023)          // Año de fabricación
                .Build();
        }
    }
}
