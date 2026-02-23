namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Grypotyphlops;

/// <summary>
/// Interface defining characteristics of Grypotyphlops (genus).
/// </summary>
public interface IGrypotyphlops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
