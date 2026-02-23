namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Gruidae.Grus;

/// <summary>
/// Interface defining characteristics of Grus (genus).
/// </summary>
public interface IGrus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
