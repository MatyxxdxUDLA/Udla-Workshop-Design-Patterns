using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    /// <summary>
    /// Clase abstracta que representa un vehículo genérico.
    /// Implementa la interfaz IVehicle y proporciona funcionalidad común para todos los vehículos.
    /// Utiliza el patrón Template Method para definir el comportamiento base.
    /// </summary>
    public abstract class Vehicle : IVehicle
    {
        #region Private properties
        /// <summary>
        /// Estado interno del motor (encendido/apagado).
        /// </summary>
        private bool _isEngineOn { get; set; }
        #endregion

        #region Properties
        /// <summary>
        /// Identificador único del vehículo.
        /// </summary>
        public readonly Guid ID;
        
        /// <summary>
        /// Número de llantas del vehículo. Debe ser sobrescrito por las clases derivadas.
        /// </summary>
        public virtual int Tires { get; set; }
        
        /// <summary>
        /// Color del vehículo.
        /// </summary>
        public string Color { get; set; }
        
        /// <summary>
        /// Marca del vehículo.
        /// </summary>
        public string Brand { get; set; }
        
        /// <summary>
        /// Modelo del vehículo.
        /// </summary>
        public string Model { get; set; }
        
        /// <summary>
        /// Cantidad actual de combustible en el tanque.
        /// </summary>
        public double Gas { get; set; }
        
        /// <summary>
        /// Límite máximo de combustible que puede contener el tanque.
        /// </summary>
        public double FuelLimit { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor base para inicializar un vehículo con sus propiedades básicas.
        /// </summary>
        /// <param name="color">Color del vehículo</param>
        /// <param name="brand">Marca del vehículo</param>
        /// <param name="model">Modelo del vehículo</param>
        /// <param name="fuelLimit">Límite máximo de combustible (por defecto 10 galones)</param>
        public Vehicle(string color, string brand, string model, double fuelLimit = 10)
        {
            ID = Guid.NewGuid();
            Color = color;
            Brand = brand;
            Model = model;
            FuelLimit = fuelLimit;
        }

        #endregion

        #region Methods
        /// <summary>
        /// Agrega combustible al tanque del vehículo.
        /// Verifica que no se exceda el límite máximo de combustible.
        /// </summary>
        /// <exception cref="Exception">Se lanza cuando el tanque está lleno</exception>
        public void AddGas()
        {
            if(Gas <= FuelLimit)
            {
                Gas += 0.1;
            }
            else
            {
                throw new Exception("Gas Full");
            }
        }
        
        /// <summary>
        /// Inicia el motor del vehículo.
        /// Verifica que el motor no esté ya encendido y que haya combustible suficiente.
        /// </summary>
        /// <exception cref="Exception">Se lanza cuando el motor ya está encendido o no hay combustible</exception>
        public void StartEngine()
        {
            if (_isEngineOn)
            {
                throw new Exception("Engine is already on");
            }
            if (NeedsGas())
            {
                throw new Exception("No enoguht gas. You need to go to Gas Station");
            }
            _isEngineOn = true;
        }

        /// <summary>
        /// Verifica si el vehículo necesita combustible.
        /// </summary>
        /// <returns>true si el combustible es menor o igual a 0, false en caso contrario</returns>
        public bool NeedsGas()
        {
            return !(Gas > 0);
        }

        /// <summary>
        /// Verifica si el motor del vehículo está encendido.
        /// </summary>
        /// <returns>true si el motor está encendido, false en caso contrario</returns>
        public bool IsEngineOn()
        {
            return _isEngineOn;
        }

        /// <summary>
        /// Detiene el motor del vehículo.
        /// Verifica que el motor esté encendido antes de apagarlo.
        /// </summary>
        /// <exception cref="Exception">Se lanza cuando el motor ya está apagado</exception>
        public void StopEngine()
        {
            if (!_isEngineOn)
            {
                throw new Exception("Enigne already stopped");
            }

            _isEngineOn = false;
        }

        #endregion

    }
}
