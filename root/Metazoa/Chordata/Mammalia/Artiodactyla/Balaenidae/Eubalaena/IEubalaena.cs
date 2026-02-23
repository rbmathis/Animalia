namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Balaenidae.Eubalaena;

/// <summary>
/// Interface defining characteristics of Eubalaena (genus).
/// </summary>
public interface IEubalaena
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
