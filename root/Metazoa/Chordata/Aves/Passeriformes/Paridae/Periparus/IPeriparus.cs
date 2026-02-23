namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Periparus;

/// <summary>
/// Interface defining characteristics of Periparus (genus).
/// </summary>
public interface IPeriparus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
