using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;

namespace DesignPatterns.Factories
{
    /// <summary>
    /// Factory concreta para la creación de vehículos Ford Explorer.
    /// Implementa el patrón Factory Method especializándose en la creación 
    /// de vehículos Explorer con características específicas de SUV.
    /// </summary>
    public class FordExplorerFactory : CarFactory
    {
        /// <summary>
        /// Crea una instancia de Ford Explorer con configuración predeterminada.
        /// Utiliza el patrón Builder para construir el vehículo con propiedades específicas.
        /// </summary>
        /// <returns>Vehicle configurado como Ford Explorer azul del año 2023</returns>
        public override Vehicle Create()
        {
            return new CarModelBuilder()
                .SetColor("blue")        // Color característico del Explorer
                .SetModel("Explorer")    // Modelo específico
                .SetYear(2023)          // Año de fabricación
                .Build();
        }
    }
}
