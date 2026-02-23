namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhinodermatidae.Rhinoderma;

/// <summary>
/// Interface defining characteristics of Rhinoderma (genus).
/// </summary>
public interface IRhinoderma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
