namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Tragulidae.Tragulus;

/// <summary>
/// Interface defining characteristics of Tragulus (genus).
/// </summary>
public interface ITragulus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
