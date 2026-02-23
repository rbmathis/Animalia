namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Balaenopteridae.Megaptera;

/// <summary>
/// Interface defining characteristics of Megaptera (genus).
/// </summary>
public interface IMegaptera
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
