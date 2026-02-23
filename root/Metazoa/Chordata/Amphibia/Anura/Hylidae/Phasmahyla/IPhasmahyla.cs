namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Phasmahyla;

/// <summary>
/// Interface defining characteristics of Phasmahyla (genus).
/// </summary>
public interface IPhasmahyla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
