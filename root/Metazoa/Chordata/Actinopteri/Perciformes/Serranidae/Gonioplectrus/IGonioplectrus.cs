namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Gonioplectrus;

/// <summary>
/// Interface defining characteristics of Gonioplectrus (genus).
/// </summary>
public interface IGonioplectrus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
