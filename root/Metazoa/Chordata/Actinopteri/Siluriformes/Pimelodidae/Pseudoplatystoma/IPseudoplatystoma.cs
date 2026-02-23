namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Pseudoplatystoma;

/// <summary>
/// Interface defining characteristics of Pseudoplatystoma (genus).
/// </summary>
public interface IPseudoplatystoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
