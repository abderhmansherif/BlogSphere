using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Shared.Abstractions.Domain
{
    public class AggregateRoot
    {
        private readonly List<IDomainEvent> _domainEvents = new();
        public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

        public void AddDomainEvent(IDomainEvent @event)
            => _domainEvents.Add(@event);

        public void ClearDomainEvents() => _domainEvents.Clear();
    }
}
