namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Rallicula;

/// <summary>
/// Interface defining characteristics of Rallicula (genus).
/// </summary>
public interface IRallicula
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
