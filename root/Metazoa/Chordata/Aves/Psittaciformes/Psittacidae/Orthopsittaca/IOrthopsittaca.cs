namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Orthopsittaca;

/// <summary>
/// Interface defining characteristics of Orthopsittaca (genus).
/// </summary>
public interface IOrthopsittaca
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
