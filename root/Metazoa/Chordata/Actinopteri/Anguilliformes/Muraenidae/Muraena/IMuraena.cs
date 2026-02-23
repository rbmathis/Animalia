namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae.Muraena;

/// <summary>
/// Interface defining characteristics of Muraena (genus).
/// </summary>
public interface IMuraena
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
