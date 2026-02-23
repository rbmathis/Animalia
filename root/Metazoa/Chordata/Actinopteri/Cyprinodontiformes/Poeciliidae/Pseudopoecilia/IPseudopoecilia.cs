namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Pseudopoecilia;

/// <summary>
/// Interface defining characteristics of Pseudopoecilia (genus).
/// </summary>
public interface IPseudopoecilia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
