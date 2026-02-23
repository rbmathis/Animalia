namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Babina;

/// <summary>
/// Interface defining characteristics of Babina (genus).
/// </summary>
public interface IBabina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
