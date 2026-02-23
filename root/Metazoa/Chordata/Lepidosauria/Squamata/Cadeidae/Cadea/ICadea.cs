namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cadeidae.Cadea;

/// <summary>
/// Interface defining characteristics of Cadea (genus).
/// </summary>
public interface ICadea
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
