namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Cophyla;

/// <summary>
/// Interface defining characteristics of Cophyla (genus).
/// </summary>
public interface ICophyla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
