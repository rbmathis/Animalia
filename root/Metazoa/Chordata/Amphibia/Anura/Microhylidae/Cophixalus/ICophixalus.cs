namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Cophixalus;

/// <summary>
/// Interface defining characteristics of Cophixalus (genus).
/// </summary>
public interface ICophixalus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
