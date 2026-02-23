namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Pseudotrapelus;

/// <summary>
/// Interface defining characteristics of Pseudotrapelus (genus).
/// </summary>
public interface IPseudotrapelus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
