namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Orthonopias;

/// <summary>
/// Interface defining characteristics of Orthonopias (genus).
/// </summary>
public interface IOrthonopias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
