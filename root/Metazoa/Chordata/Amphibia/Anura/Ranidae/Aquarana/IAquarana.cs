namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Aquarana;

/// <summary>
/// Interface defining characteristics of Aquarana (genus).
/// </summary>
public interface IAquarana
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
