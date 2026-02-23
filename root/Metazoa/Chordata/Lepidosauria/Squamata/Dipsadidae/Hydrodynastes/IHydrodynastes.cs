namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Hydrodynastes;

/// <summary>
/// Interface defining characteristics of Hydrodynastes (genus).
/// </summary>
public interface IHydrodynastes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
