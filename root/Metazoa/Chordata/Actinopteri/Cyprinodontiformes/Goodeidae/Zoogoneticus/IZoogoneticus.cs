namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae.Zoogoneticus;

/// <summary>
/// Interface defining characteristics of Zoogoneticus (genus).
/// </summary>
public interface IZoogoneticus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
