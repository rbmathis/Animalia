namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Aplodactylidae.Aplodactylus;

/// <summary>
/// Interface defining characteristics of Aplodactylus (genus).
/// </summary>
public interface IAplodactylus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
