namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Hydrophylax;

/// <summary>
/// Interface defining characteristics of Hydrophylax (genus).
/// </summary>
public interface IHydrophylax
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
