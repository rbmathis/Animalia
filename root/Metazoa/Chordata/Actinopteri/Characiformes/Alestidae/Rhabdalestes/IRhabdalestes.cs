namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Rhabdalestes;

/// <summary>
/// Interface defining characteristics of Rhabdalestes (genus).
/// </summary>
public interface IRhabdalestes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
