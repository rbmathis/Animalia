namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Tachymarptis;

/// <summary>
/// Interface defining characteristics of Tachymarptis (genus).
/// </summary>
public interface ITachymarptis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
