namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Sphenophryne;

/// <summary>
/// Interface defining characteristics of Sphenophryne (genus).
/// </summary>
public interface ISphenophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
