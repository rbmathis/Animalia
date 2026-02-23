namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Cetomimidae.Cetomimus;

/// <summary>
/// Interface defining characteristics of Cetomimus (genus).
/// </summary>
public interface ICetomimus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
