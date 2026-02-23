namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Cryptonanus;

/// <summary>
/// Interface defining characteristics of Cryptonanus (genus).
/// </summary>
public interface ICryptonanus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
