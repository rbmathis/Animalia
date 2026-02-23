namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Julianus;

/// <summary>
/// Interface defining characteristics of Julianus (genus).
/// </summary>
public interface IJulianus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
