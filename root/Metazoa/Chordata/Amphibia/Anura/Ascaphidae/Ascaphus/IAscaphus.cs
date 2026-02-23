namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ascaphidae.Ascaphus;

/// <summary>
/// Interface defining characteristics of Ascaphus (genus).
/// </summary>
public interface IAscaphus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
