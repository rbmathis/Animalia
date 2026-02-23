namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae.Rhinocrypta;

/// <summary>
/// Interface defining characteristics of Rhinocrypta (genus).
/// </summary>
public interface IRhinocrypta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
