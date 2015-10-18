using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchwabenCode.Data.Entity
{
    /// <summary>
    /// Entity Validation Result
    /// </summary>
    public class EntityValidationResult
    {
        /// <summary>
        /// Affcted property name
        /// </summary>
        public String Property { get; set; }

        /// <summary>
        /// Message of validation result
        /// </summary>
        public String Message { get; set; }

        /// <summary>
        /// Creates a new instance of <see cref="EntityValidationResult"/>
        /// </summary>
        public EntityValidationResult()
        {

        }

        /// <summary>
        /// Creates a new instance of <see cref="EntityValidationResult"/> with passes values
        /// </summary>
        public EntityValidationResult( string property, string message ) : this()
        {
            Property = property;
            Message = message;
        }
    }
}
