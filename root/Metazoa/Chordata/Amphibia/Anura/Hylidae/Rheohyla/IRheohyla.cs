namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Rheohyla;

/// <summary>
/// Interface defining characteristics of Rheohyla (genus).
/// </summary>
public interface IRheohyla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
