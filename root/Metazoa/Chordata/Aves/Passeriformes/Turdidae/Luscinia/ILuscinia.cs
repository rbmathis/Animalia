namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Luscinia;

/// <summary>
/// Interface defining characteristics of Luscinia (genus).
/// </summary>
public interface ILuscinia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
