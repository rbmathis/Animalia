namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae.Epicrates;

/// <summary>
/// Interface defining characteristics of Epicrates (genus).
/// </summary>
public interface IEpicrates
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
