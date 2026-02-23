namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anomalepididae.Liotyphlops;

/// <summary>
/// Interface defining characteristics of Liotyphlops (genus).
/// </summary>
public interface ILiotyphlops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
