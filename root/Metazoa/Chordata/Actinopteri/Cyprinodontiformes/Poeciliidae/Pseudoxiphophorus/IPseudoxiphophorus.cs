namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Pseudoxiphophorus;

/// <summary>
/// Interface defining characteristics of Pseudoxiphophorus (genus).
/// </summary>
public interface IPseudoxiphophorus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
