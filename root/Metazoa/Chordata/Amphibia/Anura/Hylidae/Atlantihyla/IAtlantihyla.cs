namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Atlantihyla;

/// <summary>
/// Interface defining characteristics of Atlantihyla (genus).
/// </summary>
public interface IAtlantihyla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
