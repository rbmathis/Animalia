namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Rhincodontidae.Rhincodon;

/// <summary>
/// Interface defining characteristics of Rhincodon (genus).
/// </summary>
public interface IRhincodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
