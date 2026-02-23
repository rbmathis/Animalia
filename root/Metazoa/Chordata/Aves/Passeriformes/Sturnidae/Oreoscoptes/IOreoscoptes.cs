namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Oreoscoptes;

/// <summary>
/// Interface defining characteristics of Oreoscoptes (genus).
/// </summary>
public interface IOreoscoptes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
