namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Nanohyla;

/// <summary>
/// Interface defining characteristics of Nanohyla (genus).
/// </summary>
public interface INanohyla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
