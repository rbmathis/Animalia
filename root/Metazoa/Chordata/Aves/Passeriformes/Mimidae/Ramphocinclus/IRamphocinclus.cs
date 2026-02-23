namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mimidae.Ramphocinclus;

/// <summary>
/// Interface defining characteristics of Ramphocinclus (genus).
/// </summary>
public interface IRamphocinclus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
