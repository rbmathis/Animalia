namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae.Rhycherus;

/// <summary>
/// Interface defining characteristics of Rhycherus (genus).
/// </summary>
public interface IRhycherus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
