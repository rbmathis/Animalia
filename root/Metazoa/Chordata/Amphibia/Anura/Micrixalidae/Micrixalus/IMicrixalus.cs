namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Micrixalidae.Micrixalus;

/// <summary>
/// Interface defining characteristics of Micrixalus (genus).
/// </summary>
public interface IMicrixalus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
