namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Phocidae.Halichoerus;

/// <summary>
/// Interface defining characteristics of Halichoerus (genus).
/// </summary>
public interface IHalichoerus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
