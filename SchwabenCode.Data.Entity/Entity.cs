namespace SchwabenCode.Data.Entity
{
    /// <summary>
    /// Base classe for simple entities
    /// </summary>
    /// <typeparam name = "TIdentifier">Type of <see name = "Id"/></typeparam>
    public abstract class Entity<TIdentifier> : IEntity<TIdentifier> where TIdentifier : struct
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        public virtual TIdentifier Id { get; set; }
    }
}