namespace SchwabenCode.Data.Entity
{
    /// <summary>
    /// Interace for simple entities
    /// </summary>
    /// <typeparam name = "TIdentifier">Type of <see name = "Id"/></typeparam>
    public interface IEntity<TIdentifier> where TIdentifier : struct
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        TIdentifier Id { get; set; }
    }
}