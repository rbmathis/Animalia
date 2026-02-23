namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Dactylopteridae.Dactyloptena;

/// <summary>
/// Interface defining characteristics of Dactyloptena (genus).
/// </summary>
public interface IDactyloptena
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
