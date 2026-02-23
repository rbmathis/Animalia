namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Monotremata.Ornithorhynchidae.Ornithorhynchus;

/// <summary>
/// Interface defining characteristics of Ornithorhynchus (genus).
/// </summary>
public interface IOrnithorhynchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
