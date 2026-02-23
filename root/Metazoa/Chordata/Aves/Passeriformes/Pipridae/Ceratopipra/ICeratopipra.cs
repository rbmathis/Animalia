namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Ceratopipra;

/// <summary>
/// Interface defining characteristics of Ceratopipra (genus).
/// </summary>
public interface ICeratopipra
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
