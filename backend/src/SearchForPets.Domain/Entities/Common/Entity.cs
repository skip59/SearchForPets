namespace SearchForPets.Domain.Entities.Common
{
    public abstract class Entity<TId>(TId id) where TId : notnull
    {
        public TId Id { get; private set; } = id;
    }
}
