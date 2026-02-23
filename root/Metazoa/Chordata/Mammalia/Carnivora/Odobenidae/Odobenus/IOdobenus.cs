namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Odobenidae.Odobenus;

/// <summary>
/// Interface defining characteristics of Odobenus (genus).
/// </summary>
public interface IOdobenus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
