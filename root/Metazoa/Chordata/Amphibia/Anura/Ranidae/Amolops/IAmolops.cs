namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Amolops;

/// <summary>
/// Interface defining characteristics of Amolops (genus).
/// </summary>
public interface IAmolops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
