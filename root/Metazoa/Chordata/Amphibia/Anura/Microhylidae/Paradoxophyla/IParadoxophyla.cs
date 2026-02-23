namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Paradoxophyla;

/// <summary>
/// Interface defining characteristics of Paradoxophyla (genus).
/// </summary>
public interface IParadoxophyla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
