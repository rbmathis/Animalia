namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Megastomatohyla;

/// <summary>
/// Interface defining characteristics of Megastomatohyla (genus).
/// </summary>
public interface IMegastomatohyla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
