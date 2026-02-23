namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Dasypodidae.Dasypus;

/// <summary>
/// Interface defining characteristics of Dasypus (genus).
/// </summary>
public interface IDasypus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
