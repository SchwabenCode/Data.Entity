﻿using System;
using System.Collections.Generic;

namespace SchwabenCode.Data.Entity
{
    /// <summary>
    /// Base class for validatable entities and provides basic methods for client side entity validation
    /// </summary>
    /// <typeparam name = "TIdentifier"></typeparam>
    public abstract class ValidateableEntity<TIdentifier> : Entity<TIdentifier>, IValidateableEntity<TIdentifier> where TIdentifier : struct
    {
        /// <summary>
        /// Validates the entity
        /// </summary>
        /// <returns>true if entity is valid</returns>
        public virtual bool IsValid()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Validates the entity
        /// </summary>
        /// <param name="validationResults">Collection of errors. Empty if valid.</param>
        /// <returns>true if entity is valid</returns>
        public virtual bool IsValid( out IEnumerable<EntityValidationResult> validationResults )
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Validates the entity
        /// </summary>
        /// <returns>A collection with errors. Empty if valid.</returns>
        public abstract IEnumerable<EntityValidationResult> Validate();
    }
}