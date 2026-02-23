namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Phoenicopteriformes.Phoenicopteridae.Phoenicopterus;

/// <summary>
/// Interface defining characteristics of Phoenicopterus (genus).
/// </summary>
public interface IPhoenicopterus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
