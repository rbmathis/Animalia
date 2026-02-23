namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Pseudocaranx;

/// <summary>
/// Interface defining characteristics of Pseudocaranx (genus).
/// </summary>
public interface IPseudocaranx
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
