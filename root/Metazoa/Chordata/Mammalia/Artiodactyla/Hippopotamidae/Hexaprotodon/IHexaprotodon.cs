namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Hippopotamidae.Hexaprotodon;

/// <summary>
/// Interface defining characteristics of Hexaprotodon (genus).
/// </summary>
public interface IHexaprotodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
