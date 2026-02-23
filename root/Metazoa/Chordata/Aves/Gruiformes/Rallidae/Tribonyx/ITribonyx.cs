namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Tribonyx;

/// <summary>
/// Interface defining characteristics of Tribonyx (genus).
/// </summary>
public interface ITribonyx
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
