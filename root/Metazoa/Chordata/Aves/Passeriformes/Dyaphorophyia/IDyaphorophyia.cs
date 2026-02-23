namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dyaphorophyia;

/// <summary>
/// Interface defining characteristics of Dyaphorophyia (genus).
/// </summary>
public interface IDyaphorophyia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
