namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Pseudocorynopoma;

/// <summary>
/// Interface defining characteristics of Pseudocorynopoma (genus).
/// </summary>
public interface IPseudocorynopoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
