namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae.Cyanolanius;

/// <summary>
/// Interface defining characteristics of Cyanolanius (genus).
/// </summary>
public interface ICyanolanius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
