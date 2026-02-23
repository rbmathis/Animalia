namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae.Neotetracus;

/// <summary>
/// Interface defining characteristics of Neotetracus (genus).
/// </summary>
public interface INeotetracus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
