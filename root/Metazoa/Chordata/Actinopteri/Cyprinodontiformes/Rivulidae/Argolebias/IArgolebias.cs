namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Argolebias;

/// <summary>
/// Interface defining characteristics of Argolebias (genus).
/// </summary>
public interface IArgolebias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
