namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pseudopimelodidae.Pseudopimelodus;

/// <summary>
/// Interface defining characteristics of Pseudopimelodus (genus).
/// </summary>
public interface IPseudopimelodus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
