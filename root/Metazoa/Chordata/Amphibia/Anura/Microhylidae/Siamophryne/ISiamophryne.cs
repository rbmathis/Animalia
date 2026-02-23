namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Siamophryne;

/// <summary>
/// Interface defining characteristics of Siamophryne (genus).
/// </summary>
public interface ISiamophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
