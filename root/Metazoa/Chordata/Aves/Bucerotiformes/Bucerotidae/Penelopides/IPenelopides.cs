namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae.Penelopides;

/// <summary>
/// Interface defining characteristics of Penelopides (genus).
/// </summary>
public interface IPenelopides
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
