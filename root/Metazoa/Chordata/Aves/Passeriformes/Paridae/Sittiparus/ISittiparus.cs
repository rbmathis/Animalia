namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Sittiparus;

/// <summary>
/// Interface defining characteristics of Sittiparus (genus).
/// </summary>
public interface ISittiparus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
