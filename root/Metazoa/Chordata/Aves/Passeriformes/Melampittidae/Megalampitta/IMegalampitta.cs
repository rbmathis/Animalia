namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Melampittidae.Megalampitta;

/// <summary>
/// Interface defining characteristics of Megalampitta (genus).
/// </summary>
public interface IMegalampitta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
