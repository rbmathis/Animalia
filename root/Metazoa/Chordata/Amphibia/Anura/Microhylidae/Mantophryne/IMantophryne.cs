namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Mantophryne;

/// <summary>
/// Interface defining characteristics of Mantophryne (genus).
/// </summary>
public interface IMantophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
