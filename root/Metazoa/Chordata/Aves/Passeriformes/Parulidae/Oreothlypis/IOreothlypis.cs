namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Oreothlypis;

/// <summary>
/// Interface defining characteristics of Oreothlypis (genus).
/// </summary>
public interface IOreothlypis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
