namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xenopeltidae.Xenopeltis;

/// <summary>
/// Interface defining characteristics of Xenopeltis (genus).
/// </summary>
public interface IXenopeltis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
