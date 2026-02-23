namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Pseudophoxinus;

/// <summary>
/// Interface defining characteristics of Pseudophoxinus (genus).
/// </summary>
public interface IPseudophoxinus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
