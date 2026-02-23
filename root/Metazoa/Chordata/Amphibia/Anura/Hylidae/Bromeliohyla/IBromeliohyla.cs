namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Bromeliohyla;

/// <summary>
/// Interface defining characteristics of Bromeliohyla (genus).
/// </summary>
public interface IBromeliohyla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
