namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pareatidae.Pareas;

/// <summary>
/// Interface defining characteristics of Pareas (genus).
/// </summary>
public interface IPareas
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
