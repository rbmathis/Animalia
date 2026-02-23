namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Oreoleuciscus;

/// <summary>
/// Interface defining characteristics of Oreoleuciscus (genus).
/// </summary>
public interface IOreoleuciscus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
