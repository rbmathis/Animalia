namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Sphenisciformes.Spheniscidae.Aptenodytes;

/// <summary>
/// Interface defining characteristics of Aptenodytes (genus).
/// </summary>
public interface IAptenodytes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
