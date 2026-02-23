namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Cetomimidae.Gyrinomimus;

/// <summary>
/// Interface defining characteristics of Gyrinomimus (genus).
/// </summary>
public interface IGyrinomimus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
