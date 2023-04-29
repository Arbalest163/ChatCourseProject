using Chat.Domain.Interfaces;

namespace Chat.Domain;
public abstract class Entity : IEntity
{
    public virtual int Id { get; set; }
}
