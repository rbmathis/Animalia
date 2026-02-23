namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Physeteridae.Physeter;

/// <summary>
/// Interface defining characteristics of Physeter (genus).
/// </summary>
public interface IPhyseter
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
