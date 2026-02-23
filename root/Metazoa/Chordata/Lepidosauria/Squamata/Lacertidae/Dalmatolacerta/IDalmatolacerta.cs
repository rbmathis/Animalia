namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Dalmatolacerta;

/// <summary>
/// Interface defining characteristics of Dalmatolacerta (genus).
/// </summary>
public interface IDalmatolacerta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
