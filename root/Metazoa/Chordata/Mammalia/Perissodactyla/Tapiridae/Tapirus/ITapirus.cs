namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Tapiridae.Tapirus;

/// <summary>
/// Interface defining characteristics of Tapirus (genus).
/// </summary>
public interface ITapirus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
