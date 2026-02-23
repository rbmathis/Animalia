namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alsodidae.Proceratophrys;

/// <summary>
/// Interface defining characteristics of Proceratophrys (genus).
/// </summary>
public interface IProceratophrys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
