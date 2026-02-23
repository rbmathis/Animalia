namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pellorneidae.Gypsophila;

/// <summary>
/// Interface defining characteristics of Gypsophila (genus).
/// </summary>
public interface IGypsophila
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
