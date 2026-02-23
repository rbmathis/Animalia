namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Sirenia.Dugongidae.Dugong;

/// <summary>
/// Interface defining characteristics of Dugong (genus).
/// </summary>
public interface IDugong
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
