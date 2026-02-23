namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Amerotyphlops;

/// <summary>
/// Interface defining characteristics of Amerotyphlops (genus).
/// </summary>
public interface IAmerotyphlops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
