namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Hypoplectrus;

/// <summary>
/// Interface defining characteristics of Hypoplectrus (genus).
/// </summary>
public interface IHypoplectrus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
