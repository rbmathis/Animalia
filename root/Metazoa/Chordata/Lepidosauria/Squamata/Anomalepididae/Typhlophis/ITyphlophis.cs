namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anomalepididae.Typhlophis;

/// <summary>
/// Interface defining characteristics of Typhlophis (genus).
/// </summary>
public interface ITyphlophis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
