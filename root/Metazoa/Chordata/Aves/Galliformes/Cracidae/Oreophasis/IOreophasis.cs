namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae.Oreophasis;

/// <summary>
/// Interface defining characteristics of Oreophasis (genus).
/// </summary>
public interface IOreophasis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
