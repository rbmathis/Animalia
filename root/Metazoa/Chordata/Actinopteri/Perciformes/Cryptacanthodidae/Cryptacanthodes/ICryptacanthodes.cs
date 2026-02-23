namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cryptacanthodidae.Cryptacanthodes;

/// <summary>
/// Interface defining characteristics of Cryptacanthodes (genus).
/// </summary>
public interface ICryptacanthodes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
