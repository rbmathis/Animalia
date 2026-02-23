namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae.Lepidoblepharis;

/// <summary>
/// Interface defining characteristics of Lepidoblepharis (genus).
/// </summary>
public interface ILepidoblepharis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
