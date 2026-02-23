namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae.Pseudosphromenus;

/// <summary>
/// Interface defining characteristics of Pseudosphromenus (genus).
/// </summary>
public interface IPseudosphromenus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
