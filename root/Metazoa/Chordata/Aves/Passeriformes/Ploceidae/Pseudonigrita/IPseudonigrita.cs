namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ploceidae.Pseudonigrita;

/// <summary>
/// Interface defining characteristics of Pseudonigrita (genus).
/// </summary>
public interface IPseudonigrita
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
