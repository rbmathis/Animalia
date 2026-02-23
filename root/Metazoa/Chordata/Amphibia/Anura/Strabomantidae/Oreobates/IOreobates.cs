namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Oreobates;

/// <summary>
/// Interface defining characteristics of Oreobates (genus).
/// </summary>
public interface IOreobates
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
