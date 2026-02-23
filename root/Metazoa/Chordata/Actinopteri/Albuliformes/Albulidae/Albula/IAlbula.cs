namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Albuliformes.Albulidae.Albula;

/// <summary>
/// Interface defining characteristics of Albula (genus).
/// </summary>
public interface IAlbula
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
