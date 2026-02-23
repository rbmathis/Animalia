namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Gastrophryne;

/// <summary>
/// Interface defining characteristics of Gastrophryne (genus).
/// </summary>
public interface IGastrophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
