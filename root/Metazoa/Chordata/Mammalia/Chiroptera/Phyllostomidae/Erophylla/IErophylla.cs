namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Erophylla;

/// <summary>
/// Interface defining characteristics of Erophylla (genus).
/// </summary>
public interface IErophylla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
