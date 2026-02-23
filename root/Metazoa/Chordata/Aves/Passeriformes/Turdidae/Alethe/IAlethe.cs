namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Alethe;

/// <summary>
/// Interface defining characteristics of Alethe (genus).
/// </summary>
public interface IAlethe
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
