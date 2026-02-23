namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Platanistidae.Platanista;

/// <summary>
/// Interface defining characteristics of Platanista (genus).
/// </summary>
public interface IPlatanista
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
