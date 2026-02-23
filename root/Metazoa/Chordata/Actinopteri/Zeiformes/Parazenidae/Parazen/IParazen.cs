namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Parazenidae.Parazen;

/// <summary>
/// Interface defining characteristics of Parazen (genus).
/// </summary>
public interface IParazen
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
