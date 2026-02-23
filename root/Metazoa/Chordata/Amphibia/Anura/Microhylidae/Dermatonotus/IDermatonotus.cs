namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Dermatonotus;

/// <summary>
/// Interface defining characteristics of Dermatonotus (genus).
/// </summary>
public interface IDermatonotus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
