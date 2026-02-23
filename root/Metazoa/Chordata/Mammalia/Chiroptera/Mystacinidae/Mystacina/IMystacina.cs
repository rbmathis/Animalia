namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Mystacinidae.Mystacina;

/// <summary>
/// Interface defining characteristics of Mystacina (genus).
/// </summary>
public interface IMystacina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
