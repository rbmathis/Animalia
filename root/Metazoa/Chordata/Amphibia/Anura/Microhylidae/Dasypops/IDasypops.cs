namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Dasypops;

/// <summary>
/// Interface defining characteristics of Dasypops (genus).
/// </summary>
public interface IDasypops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
