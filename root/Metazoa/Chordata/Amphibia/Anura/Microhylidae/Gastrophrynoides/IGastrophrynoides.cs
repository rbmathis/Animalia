namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Gastrophrynoides;

/// <summary>
/// Interface defining characteristics of Gastrophrynoides (genus).
/// </summary>
public interface IGastrophrynoides
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
