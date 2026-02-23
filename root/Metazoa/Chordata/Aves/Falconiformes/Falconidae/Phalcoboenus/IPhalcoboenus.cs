namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae.Phalcoboenus;

/// <summary>
/// Interface defining characteristics of Phalcoboenus (genus).
/// </summary>
public interface IPhalcoboenus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
