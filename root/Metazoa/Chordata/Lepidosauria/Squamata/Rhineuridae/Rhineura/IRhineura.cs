namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Rhineuridae.Rhineura;

/// <summary>
/// Interface defining characteristics of Rhineura (genus).
/// </summary>
public interface IRhineura
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
