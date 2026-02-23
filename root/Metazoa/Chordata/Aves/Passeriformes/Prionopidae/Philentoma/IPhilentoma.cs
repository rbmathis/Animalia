namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Prionopidae.Philentoma;

/// <summary>
/// Interface defining characteristics of Philentoma (genus).
/// </summary>
public interface IPhilentoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
