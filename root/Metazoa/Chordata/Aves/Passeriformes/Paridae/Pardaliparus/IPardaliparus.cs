namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Pardaliparus;

/// <summary>
/// Interface defining characteristics of Pardaliparus (genus).
/// </summary>
public interface IPardaliparus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
