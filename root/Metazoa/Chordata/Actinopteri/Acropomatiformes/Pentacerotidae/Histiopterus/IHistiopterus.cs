namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Pentacerotidae.Histiopterus;

/// <summary>
/// Interface defining characteristics of Histiopterus (genus).
/// </summary>
public interface IHistiopterus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
