namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anhimidae.Chauna;

/// <summary>
/// Interface defining characteristics of Chauna (genus).
/// </summary>
public interface IChauna
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
