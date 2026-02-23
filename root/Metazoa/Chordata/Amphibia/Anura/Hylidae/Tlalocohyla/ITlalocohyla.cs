namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Tlalocohyla;

/// <summary>
/// Interface defining characteristics of Tlalocohyla (genus).
/// </summary>
public interface ITlalocohyla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
