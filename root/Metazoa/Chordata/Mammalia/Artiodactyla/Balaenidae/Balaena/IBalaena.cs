namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Balaenidae.Balaena;

/// <summary>
/// Interface defining characteristics of Balaena (genus).
/// </summary>
public interface IBalaena
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
