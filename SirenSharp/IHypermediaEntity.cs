namespace SirenSharp
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface to be implemented by objects that should appear as hypermedia entities in an API.
    /// </summary>
    public interface IHypermediaEntity
    {
        /// <summary>
        /// Gets a list of Siren classes associated with this entity
        /// </summary>
        /// <returns>An IEnumerable list of strings</returns>
        IEnumerable<string> GetSirenClasses();

        /// <summary>
        /// Gets a list of Siren sub-entities associated with this entity
        /// </summary>
        /// <returns>An IEnumerable list of subentities</returns>
        IEnumerable<SubEntity> GetSirenSubEntities();

        /// <summary>
        /// Gets a list of Siren links associated with this entity
        /// </summary>
        /// <returns>An IEnumerable list of links</returns>
        IEnumerable<Link> GetSirenLinks();

        /// <summary>
        /// Gets a list of Siren actinos associated with this entity
        /// </summary>
        /// <returns>An IEnumerable list of actions</returns>
        IEnumerable<Action> GetSirenActions();
    }
}
