namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Myrrophis;

/// <summary>
/// Interface defining characteristics of Myrrophis (genus).
/// </summary>
public interface IMyrrophis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
