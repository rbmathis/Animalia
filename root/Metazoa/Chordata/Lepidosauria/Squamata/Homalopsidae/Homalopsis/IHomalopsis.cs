namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Homalopsis;

/// <summary>
/// Interface defining characteristics of Homalopsis (genus).
/// </summary>
public interface IHomalopsis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
