namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Otocolobus;

/// <summary>
/// Interface defining characteristics of Otocolobus (genus).
/// </summary>
public interface IOtocolobus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
