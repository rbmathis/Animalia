namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Acrochordidae.Plagiopholis;

/// <summary>
/// Interface defining characteristics of Plagiopholis (genus).
/// </summary>
public interface IPlagiopholis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
