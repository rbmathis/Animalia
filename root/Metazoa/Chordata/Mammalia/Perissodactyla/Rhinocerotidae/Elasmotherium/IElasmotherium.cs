namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Rhinocerotidae.Elasmotherium;

/// <summary>
/// Interface defining characteristics of Elasmotherium (genus).
/// </summary>
public interface IElasmotherium
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
