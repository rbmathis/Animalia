namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Catharus;

/// <summary>
/// Interface defining characteristics of Catharus (genus).
/// </summary>
public interface ICatharus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
