namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Geothlypis;

/// <summary>
/// Interface defining characteristics of Geothlypis (genus).
/// </summary>
public interface IGeothlypis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
