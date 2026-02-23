namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Gallinula;

/// <summary>
/// Interface defining characteristics of Gallinula (genus).
/// </summary>
public interface IGallinula
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
