namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Mantidactylus;

/// <summary>
/// Interface defining characteristics of Mantidactylus (genus).
/// </summary>
public interface IMantidactylus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
