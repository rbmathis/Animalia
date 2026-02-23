namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Muscisaxicola;

/// <summary>
/// Interface defining characteristics of Muscisaxicola (genus).
/// </summary>
public interface IMuscisaxicola
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
