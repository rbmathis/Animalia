namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae.Archaius;

/// <summary>
/// Interface defining characteristics of Archaius (genus).
/// </summary>
public interface IArchaius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
