namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae.Tylas;

/// <summary>
/// Interface defining characteristics of Tylas (genus).
/// </summary>
public interface ITylas
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
