namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Centrolophidae.Hyperoglyphe;

/// <summary>
/// Interface defining characteristics of Hyperoglyphe (genus).
/// </summary>
public interface IHyperoglyphe
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
