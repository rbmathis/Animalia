namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Nectophryne;

/// <summary>
/// Interface defining characteristics of Nectophryne (genus).
/// </summary>
public interface INectophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
