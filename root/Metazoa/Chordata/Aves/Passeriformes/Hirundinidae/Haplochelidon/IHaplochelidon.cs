namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae.Haplochelidon;

/// <summary>
/// Interface defining characteristics of Haplochelidon (genus).
/// </summary>
public interface IHaplochelidon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
