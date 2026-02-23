namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Gobiocypris;

/// <summary>
/// Interface defining characteristics of Gobiocypris (genus).
/// </summary>
public interface IGobiocypris
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
