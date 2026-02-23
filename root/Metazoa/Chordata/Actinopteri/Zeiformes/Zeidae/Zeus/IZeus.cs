namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Zeidae.Zeus;

/// <summary>
/// Interface defining characteristics of Zeus (genus).
/// </summary>
public interface IZeus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
