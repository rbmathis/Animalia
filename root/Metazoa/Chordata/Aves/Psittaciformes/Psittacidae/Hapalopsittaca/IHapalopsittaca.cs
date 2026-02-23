namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Hapalopsittaca;

/// <summary>
/// Interface defining characteristics of Hapalopsittaca (genus).
/// </summary>
public interface IHapalopsittaca
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
