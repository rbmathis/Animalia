namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Blanidae.Blanus;

/// <summary>
/// Interface defining characteristics of Blanus (genus).
/// </summary>
public interface IBlanus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
