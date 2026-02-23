namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Cataponera;

/// <summary>
/// Interface defining characteristics of Cataponera (genus).
/// </summary>
public interface ICataponera
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
