namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Pseudorana;

/// <summary>
/// Interface defining characteristics of Pseudorana (genus).
/// </summary>
public interface IPseudorana
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
