namespace SirenSharp
{
    using System.Collections.Generic;

    public interface IHypermediaEntity
    {
        IEnumerable<string> GetSirenClasses();

        IEnumerable<SubEntity> GetSirenSubEntities();

        IEnumerable<Link> GetSirenLinks();

        IEnumerable<Action> GetSirenActions();
    }
}
