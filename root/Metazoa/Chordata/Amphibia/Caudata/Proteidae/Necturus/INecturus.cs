namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Proteidae.Necturus;

/// <summary>
/// Interface defining characteristics of Necturus (genus).
/// </summary>
public interface INecturus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
