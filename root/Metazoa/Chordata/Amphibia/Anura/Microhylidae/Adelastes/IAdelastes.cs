namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Adelastes;

/// <summary>
/// Interface defining characteristics of Adelastes (genus).
/// </summary>
public interface IAdelastes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
