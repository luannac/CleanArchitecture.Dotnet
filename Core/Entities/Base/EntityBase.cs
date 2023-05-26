namespace Core.Entities.Base
{
    public abstract class EntityBase<Tid> : IEntityBase<Tid>
    {
        public virtual Tid Id { get; set;}
    }
}