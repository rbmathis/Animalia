namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Pseudophilautus;

/// <summary>
/// Interface defining characteristics of Pseudophilautus (genus).
/// </summary>
public interface IPseudophilautus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
