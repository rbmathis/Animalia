namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Cyclopsitta;

/// <summary>
/// Interface defining characteristics of Cyclopsitta (genus).
/// </summary>
public interface ICyclopsitta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
