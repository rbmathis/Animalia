namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Chiroxiphia;

/// <summary>
/// Interface defining characteristics of Chiroxiphia (genus).
/// </summary>
public interface IChiroxiphia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
