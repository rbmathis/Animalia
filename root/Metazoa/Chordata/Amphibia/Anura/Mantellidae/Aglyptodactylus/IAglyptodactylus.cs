namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Aglyptodactylus;

/// <summary>
/// Interface defining characteristics of Aglyptodactylus (genus).
/// </summary>
public interface IAglyptodactylus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
