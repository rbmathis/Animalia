namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anomochilidae.Anomochilus;

/// <summary>
/// Interface defining characteristics of Anomochilus (genus).
/// </summary>
public interface IAnomochilus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
