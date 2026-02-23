namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Orthonychidae.Orthonyx;

/// <summary>
/// Interface defining characteristics of Orthonyx (genus).
/// </summary>
public interface IOrthonyx
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
