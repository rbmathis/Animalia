namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Iniidae.Inia;

/// <summary>
/// Interface defining characteristics of Inia (genus).
/// </summary>
public interface IInia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
