namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Gallotia;

/// <summary>
/// Interface defining characteristics of Gallotia (genus).
/// </summary>
public interface IGallotia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
