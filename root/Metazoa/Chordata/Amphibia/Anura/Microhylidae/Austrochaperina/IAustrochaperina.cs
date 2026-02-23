namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Austrochaperina;

/// <summary>
/// Interface defining characteristics of Austrochaperina (genus).
/// </summary>
public interface IAustrochaperina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
