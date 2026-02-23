namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Bathylagidae.Pseudobathylagus;

/// <summary>
/// Interface defining characteristics of Pseudobathylagus (genus).
/// </summary>
public interface IPseudobathylagus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
