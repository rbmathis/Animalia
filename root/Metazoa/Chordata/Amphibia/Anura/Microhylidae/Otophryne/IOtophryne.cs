namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Otophryne;

/// <summary>
/// Interface defining characteristics of Otophryne (genus).
/// </summary>
public interface IOtophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
