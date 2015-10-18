using System.Collections.Generic;

namespace SchwabenCode.Data.Entity
{
    /// <summary>
    /// Interface for validateable entities
    /// </summary>
    /// <typeparam name = "TIdentifier">Type if <paramref name = "Id"/></typeparam>
    public interface IValidateableEntity<TIdentifier> : IEntity<TIdentifier> where TIdentifier : struct
    {
        /// <summary>
        /// Validates the entity
        /// </summary>
        /// <returns>true if entity is valid</returns>
        bool IsValid();

        /// <summary>
        /// Validates the entity
        /// </summary>
        /// <param name="validationResults">Errors</param>
        /// <returns>true if entity is valid</returns>
        bool IsValid( out IEnumerable<EntityValidationResult> validationResults );

        /// <summary>
        /// Validates the entity
        /// </summary>
        /// <returns>A collection with errors. Empty if valid.</returns>
        IEnumerable<EntityValidationResult> Validate();
    }
}