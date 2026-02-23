namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Ecnomiohyla;

/// <summary>
/// Interface defining characteristics of Ecnomiohyla (genus).
/// </summary>
public interface IEcnomiohyla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
