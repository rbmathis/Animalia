namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae.Pseudochelidon;

/// <summary>
/// Interface defining characteristics of Pseudochelidon (genus).
/// </summary>
public interface IPseudochelidon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
