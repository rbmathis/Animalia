namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Ameivula;

/// <summary>
/// Interface defining characteristics of Ameivula (genus).
/// </summary>
public interface IAmeivula
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
