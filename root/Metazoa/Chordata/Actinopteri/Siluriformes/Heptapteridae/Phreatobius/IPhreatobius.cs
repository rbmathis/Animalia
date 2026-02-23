namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Phreatobius;

/// <summary>
/// Interface defining characteristics of Phreatobius (genus).
/// </summary>
public interface IPhreatobius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
