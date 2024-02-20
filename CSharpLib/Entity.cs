namespace CSharpLib;

public interface IEntity
{
    object Id { get; }
}

public record Entity(int Id) : IEntity
{
    object IEntity.Id => this.Id;
}