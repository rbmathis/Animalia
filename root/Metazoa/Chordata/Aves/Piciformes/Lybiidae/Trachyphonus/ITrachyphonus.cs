namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Lybiidae.Trachyphonus;

/// <summary>
/// Interface defining characteristics of Trachyphonus (genus).
/// </summary>
public interface ITrachyphonus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
