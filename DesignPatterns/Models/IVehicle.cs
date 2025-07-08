using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    /// <summary>
    /// Interfaz que define el comportamiento básico que debe tener todo vehículo.
    /// Establece el contrato para las operaciones fundamentales del motor y combustible.
    /// </summary>
    public interface IVehicle
    {
        /// <summary>
        /// Inicia el motor del vehículo.
        /// </summary>
        void StartEngine();

        /// <summary>
        /// Detiene el motor del vehículo.
        /// </summary>
        void StopEngine();

        /// <summary>
        /// Agrega combustible al tanque del vehículo.
        /// </summary>
        void AddGas();

        /// <summary>
        /// Verifica si el vehículo necesita combustible.
        /// </summary>
        /// <returns>true si necesita combustible, false en caso contrario</returns>
        bool NeedsGas();

        /// <summary>
        /// Verifica si el motor del vehículo está encendido.
        /// </summary>
        /// <returns>true si el motor está encendido, false en caso contrario</returns>
        bool IsEngineOn();
    }
}
