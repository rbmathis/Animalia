namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Acheilognathidae.Pseudorhodeus;

/// <summary>
/// Interface defining characteristics of Pseudorhodeus (genus).
/// </summary>
public interface IPseudorhodeus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
