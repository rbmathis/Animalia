namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Mitsukurinidae.Mitsukurina;

/// <summary>
/// Interface defining characteristics of Mitsukurina (genus).
/// </summary>
public interface IMitsukurina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
