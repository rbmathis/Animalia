namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Corythomantis;

/// <summary>
/// Interface defining characteristics of Corythomantis (genus).
/// </summary>
public interface ICorythomantis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
