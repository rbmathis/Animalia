namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Sphaenorhynchus;

/// <summary>
/// Interface defining characteristics of Sphaenorhynchus (genus).
/// </summary>
public interface ISphaenorhynchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
