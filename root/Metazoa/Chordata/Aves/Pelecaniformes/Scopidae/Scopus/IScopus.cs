namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Scopidae.Scopus;

/// <summary>
/// Interface defining characteristics of Scopus (genus).
/// </summary>
public interface IScopus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
