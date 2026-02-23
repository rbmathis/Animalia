namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Acris;

/// <summary>
/// Interface defining characteristics of Acris (genus).
/// </summary>
public interface IAcris
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
