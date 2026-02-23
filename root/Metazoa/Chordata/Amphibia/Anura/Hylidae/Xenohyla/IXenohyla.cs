namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Xenohyla;

/// <summary>
/// Interface defining characteristics of Xenohyla (genus).
/// </summary>
public interface IXenohyla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
