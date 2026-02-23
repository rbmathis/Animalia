namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Nesorohyla;

/// <summary>
/// Interface defining characteristics of Nesorohyla (genus).
/// </summary>
public interface INesorohyla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
