namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Hellenolacerta;

/// <summary>
/// Interface defining characteristics of Hellenolacerta (genus).
/// </summary>
public interface IHellenolacerta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
