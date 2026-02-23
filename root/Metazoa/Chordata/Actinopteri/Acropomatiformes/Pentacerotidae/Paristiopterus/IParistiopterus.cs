namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Pentacerotidae.Paristiopterus;

/// <summary>
/// Interface defining characteristics of Paristiopterus (genus).
/// </summary>
public interface IParistiopterus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
