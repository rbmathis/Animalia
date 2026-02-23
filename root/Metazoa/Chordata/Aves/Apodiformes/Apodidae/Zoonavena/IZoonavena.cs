namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Zoonavena;

/// <summary>
/// Interface defining characteristics of Zoonavena (genus).
/// </summary>
public interface IZoonavena
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
