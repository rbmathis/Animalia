namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae.Otis;

/// <summary>
/// Interface defining characteristics of Otis (genus).
/// </summary>
public interface IOtis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
