namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Zenionidae.Cyttomimus;

/// <summary>
/// Interface defining characteristics of Cyttomimus (genus).
/// </summary>
public interface ICyttomimus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
