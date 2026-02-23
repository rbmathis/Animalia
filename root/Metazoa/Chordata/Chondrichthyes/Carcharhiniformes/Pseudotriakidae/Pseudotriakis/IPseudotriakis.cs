namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Pseudotriakidae.Pseudotriakis;

/// <summary>
/// Interface defining characteristics of Pseudotriakis (genus).
/// </summary>
public interface IPseudotriakis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
