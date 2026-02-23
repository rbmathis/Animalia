namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Monticola;

/// <summary>
/// Interface defining characteristics of Monticola (genus).
/// </summary>
public interface IMonticola
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
