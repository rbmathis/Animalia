namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Amphispizopsis;

/// <summary>
/// Interface defining characteristics of Amphispizopsis (genus).
/// </summary>
public interface IAmphispizopsis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
