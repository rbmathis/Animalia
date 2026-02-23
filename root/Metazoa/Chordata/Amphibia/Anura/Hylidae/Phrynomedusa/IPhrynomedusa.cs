namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Phrynomedusa;

/// <summary>
/// Interface defining characteristics of Phrynomedusa (genus).
/// </summary>
public interface IPhrynomedusa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
