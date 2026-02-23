namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Zenionidae.Zenion;

/// <summary>
/// Interface defining characteristics of Zenion (genus).
/// </summary>
public interface IZenion
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
