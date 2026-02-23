namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Zeidae.Zenopsis;

/// <summary>
/// Interface defining characteristics of Zenopsis (genus).
/// </summary>
public interface IZenopsis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
