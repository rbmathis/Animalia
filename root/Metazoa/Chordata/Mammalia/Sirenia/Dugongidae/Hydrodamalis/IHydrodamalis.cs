namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Sirenia.Dugongidae.Hydrodamalis;

/// <summary>
/// Interface defining characteristics of Hydrodamalis (genus).
/// </summary>
public interface IHydrodamalis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
