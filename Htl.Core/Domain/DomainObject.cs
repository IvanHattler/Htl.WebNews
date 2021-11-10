using System;

namespace Htl.Core.Domain
{
    public abstract class DomainObject<IdT>
    {
        public IdT ID { get; private set; }

        public abstract DomainObject<IdT> GetCopy();
    }
}
