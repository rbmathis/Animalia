namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Phocoenidae.Neophocaena;

/// <summary>
/// Interface defining characteristics of Neophocaena (genus).
/// </summary>
public interface INeophocaena
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
