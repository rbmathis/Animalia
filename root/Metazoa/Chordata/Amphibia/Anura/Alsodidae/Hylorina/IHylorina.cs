namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alsodidae.Hylorina;

/// <summary>
/// Interface defining characteristics of Hylorina (genus).
/// </summary>
public interface IHylorina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
