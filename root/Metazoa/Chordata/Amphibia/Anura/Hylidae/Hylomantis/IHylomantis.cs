namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Hylomantis;

/// <summary>
/// Interface defining characteristics of Hylomantis (genus).
/// </summary>
public interface IHylomantis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
