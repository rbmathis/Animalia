namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pareatidae.Aplopeltura;

/// <summary>
/// Interface defining characteristics of Aplopeltura (genus).
/// </summary>
public interface IAplopeltura
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
