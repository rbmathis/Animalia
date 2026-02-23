namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Pitheciidae.Plecturocebus;

/// <summary>
/// Interface defining characteristics of Plecturocebus (genus).
/// </summary>
public interface IPlecturocebus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
