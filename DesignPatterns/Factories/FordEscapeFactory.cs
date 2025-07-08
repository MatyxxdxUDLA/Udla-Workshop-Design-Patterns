using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;

namespace DesignPatterns.Factories
{
    /// <summary>
    /// Factory concreta para la creación de vehículos Ford Escape.
    /// Implementa el patrón Factory Method especializándose en la creación 
    /// de vehículos Escape con características específicas de SUV compacto.
    /// </summary>
    public class FordEscapeFactory : CarFactory
    {
        /// <summary>
        /// Crea una instancia de Ford Escape con configuración predeterminada.
        /// Utiliza el patrón Builder para construir el vehículo con propiedades específicas.
        /// </summary>
        /// <returns>Vehicle configurado como Ford Escape rojo del año 2023</returns>
        public override Vehicle Create()
        {
            return new CarModelBuilder()
                .SetColor("red")         // Color característico del Escape
                .SetModel("Escape")      // Modelo específico
                .SetYear(2023)          // Año de fabricación
                .Build();
        }
    }
}
