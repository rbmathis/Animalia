namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Neofelis;

/// <summary>
/// Interface defining characteristics of Neofelis (genus).
/// </summary>
public interface INeofelis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
