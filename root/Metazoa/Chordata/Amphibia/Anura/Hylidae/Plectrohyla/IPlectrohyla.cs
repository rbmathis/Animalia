namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Plectrohyla;

/// <summary>
/// Interface defining characteristics of Plectrohyla (genus).
/// </summary>
public interface IPlectrohyla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
