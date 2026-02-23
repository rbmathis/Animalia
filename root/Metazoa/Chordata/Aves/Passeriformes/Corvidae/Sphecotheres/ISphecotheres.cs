namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Sphecotheres;

/// <summary>
/// Interface defining characteristics of Sphecotheres (genus).
/// </summary>
public interface ISphecotheres
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
