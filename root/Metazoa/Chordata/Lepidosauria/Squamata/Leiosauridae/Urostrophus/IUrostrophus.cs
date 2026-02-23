namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leiosauridae.Urostrophus;

/// <summary>
/// Interface defining characteristics of Urostrophus (genus).
/// </summary>
public interface IUrostrophus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
