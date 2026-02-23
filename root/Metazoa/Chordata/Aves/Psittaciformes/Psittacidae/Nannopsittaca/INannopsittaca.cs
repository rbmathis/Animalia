namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Nannopsittaca;

/// <summary>
/// Interface defining characteristics of Nannopsittaca (genus).
/// </summary>
public interface INannopsittaca
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
