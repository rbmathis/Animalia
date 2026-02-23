namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Sarcohyla;

/// <summary>
/// Interface defining characteristics of Sarcohyla (genus).
/// </summary>
public interface ISarcohyla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
