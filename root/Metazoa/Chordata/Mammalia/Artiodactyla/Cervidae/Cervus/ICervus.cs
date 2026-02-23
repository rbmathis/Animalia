namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Cervus;

/// <summary>
/// Interface defining characteristics of Cervus (genus).
/// </summary>
public interface ICervus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
