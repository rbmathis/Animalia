namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae.Rhinomuraena;

/// <summary>
/// Interface defining characteristics of Rhinomuraena (genus).
/// </summary>
public interface IRhinomuraena
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
