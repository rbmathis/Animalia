namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Ephalophis;

/// <summary>
/// Interface defining characteristics of Ephalophis (genus).
/// </summary>
public interface IEphalophis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
