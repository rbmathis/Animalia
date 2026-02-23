namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Pentacerotidae.Pseudopentaceros;

/// <summary>
/// Interface defining characteristics of Pseudopentaceros (genus).
/// </summary>
public interface IPseudopentaceros
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
