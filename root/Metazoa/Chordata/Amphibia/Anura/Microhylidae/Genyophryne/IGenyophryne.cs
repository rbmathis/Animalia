namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Genyophryne;

/// <summary>
/// Interface defining characteristics of Genyophryne (genus).
/// </summary>
public interface IGenyophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
