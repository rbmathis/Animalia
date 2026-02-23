namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Psophiidae.Psophia;

/// <summary>
/// Interface defining characteristics of Psophia (genus).
/// </summary>
public interface IPsophia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
