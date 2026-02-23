namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Nandiniidae.Nandinia;

/// <summary>
/// Interface defining characteristics of Nandinia (genus).
/// </summary>
public interface INandinia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
