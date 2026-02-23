namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Pygarrhichas;

/// <summary>
/// Interface defining characteristics of Pygarrhichas (genus).
/// </summary>
public interface IPygarrhichas
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
