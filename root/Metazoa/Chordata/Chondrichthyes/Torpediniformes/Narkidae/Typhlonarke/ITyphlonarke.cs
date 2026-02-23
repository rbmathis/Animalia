namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Narkidae.Typhlonarke;

/// <summary>
/// Interface defining characteristics of Typhlonarke (genus).
/// </summary>
public interface ITyphlonarke
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
