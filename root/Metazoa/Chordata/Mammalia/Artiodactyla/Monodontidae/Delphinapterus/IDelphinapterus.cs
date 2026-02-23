namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Monodontidae.Delphinapterus;

/// <summary>
/// Interface defining characteristics of Delphinapterus (genus).
/// </summary>
public interface IDelphinapterus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
