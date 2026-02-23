namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Rhinocerotidae.Dicerorhinus;

/// <summary>
/// Interface defining characteristics of Dicerorhinus (genus).
/// </summary>
public interface IDicerorhinus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
