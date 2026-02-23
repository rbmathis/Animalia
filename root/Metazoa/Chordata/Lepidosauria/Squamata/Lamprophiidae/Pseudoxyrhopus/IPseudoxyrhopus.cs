namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Pseudoxyrhopus;

/// <summary>
/// Interface defining characteristics of Pseudoxyrhopus (genus).
/// </summary>
public interface IPseudoxyrhopus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
