namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Ctenophryne;

/// <summary>
/// Interface defining characteristics of Ctenophryne (genus).
/// </summary>
public interface ICtenophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
