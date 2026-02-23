namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Micryletta;

/// <summary>
/// Interface defining characteristics of Micryletta (genus).
/// </summary>
public interface IMicryletta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
