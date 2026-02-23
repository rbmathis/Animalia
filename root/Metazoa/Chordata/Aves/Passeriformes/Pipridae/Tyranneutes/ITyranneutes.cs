namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Tyranneutes;

/// <summary>
/// Interface defining characteristics of Tyranneutes (genus).
/// </summary>
public interface ITyranneutes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
