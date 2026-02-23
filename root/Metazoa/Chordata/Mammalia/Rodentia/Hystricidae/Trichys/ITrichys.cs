namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Hystricidae.Trichys;

/// <summary>
/// Interface defining characteristics of Trichys (genus).
/// </summary>
public interface ITrichys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
