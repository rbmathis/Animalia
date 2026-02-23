namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae.Haringtonhippus;

/// <summary>
/// Interface defining characteristics of Haringtonhippus (genus).
/// </summary>
public interface IHaringtonhippus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
