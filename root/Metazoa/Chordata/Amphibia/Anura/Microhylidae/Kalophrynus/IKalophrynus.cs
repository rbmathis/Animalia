namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Kalophrynus;

/// <summary>
/// Interface defining characteristics of Kalophrynus (genus).
/// </summary>
public interface IKalophrynus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
