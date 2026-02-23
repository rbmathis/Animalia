namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucorvidae.Bucorvus;

/// <summary>
/// Interface defining characteristics of Bucorvus (genus).
/// </summary>
public interface IBucorvus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
