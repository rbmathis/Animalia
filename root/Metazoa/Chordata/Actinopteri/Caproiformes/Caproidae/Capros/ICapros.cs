namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Caproiformes.Caproidae.Capros;

/// <summary>
/// Interface defining characteristics of Capros (genus).
/// </summary>
public interface ICapros
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
