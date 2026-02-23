namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Bucconidae.Malacoptila;

/// <summary>
/// Interface defining characteristics of Malacoptila (genus).
/// </summary>
public interface IMalacoptila
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
