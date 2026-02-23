namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ailuridae.Ailurus;

/// <summary>
/// Interface defining characteristics of Ailurus (genus).
/// </summary>
public interface IAilurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
