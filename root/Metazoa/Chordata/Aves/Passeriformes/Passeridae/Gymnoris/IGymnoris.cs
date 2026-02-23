namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae.Gymnoris;

/// <summary>
/// Interface defining characteristics of Gymnoris (genus).
/// </summary>
public interface IGymnoris
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
