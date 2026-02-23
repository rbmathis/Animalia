namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Pseudotrichonotidae.Pseudotrichonotus;

/// <summary>
/// Interface defining characteristics of Pseudotrichonotus (genus).
/// </summary>
public interface IPseudotrichonotus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
