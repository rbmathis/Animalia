namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Rhinotyphlops;

/// <summary>
/// Interface defining characteristics of Rhinotyphlops (genus).
/// </summary>
public interface IRhinotyphlops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
