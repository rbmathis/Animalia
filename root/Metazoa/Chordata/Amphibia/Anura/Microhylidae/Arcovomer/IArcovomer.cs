namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Arcovomer;

/// <summary>
/// Interface defining characteristics of Arcovomer (genus).
/// </summary>
public interface IArcovomer
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
