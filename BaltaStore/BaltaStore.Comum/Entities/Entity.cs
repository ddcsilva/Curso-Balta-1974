using FluentValidator;

namespace BaltaStore.Comum.Entities;

public abstract class Entity : Notifiable
{
    public Entity()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
}
