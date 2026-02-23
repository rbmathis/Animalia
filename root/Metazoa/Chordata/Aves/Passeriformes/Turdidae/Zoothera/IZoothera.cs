namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Zoothera;

/// <summary>
/// Interface defining characteristics of Zoothera (genus).
/// </summary>
public interface IZoothera
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
