namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Rhombophryne;

/// <summary>
/// Interface defining characteristics of Rhombophryne (genus).
/// </summary>
public interface IRhombophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
