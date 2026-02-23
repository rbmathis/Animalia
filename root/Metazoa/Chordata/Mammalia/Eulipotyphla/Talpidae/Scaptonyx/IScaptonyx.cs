namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Scaptonyx;

/// <summary>
/// Interface defining characteristics of Scaptonyx (genus).
/// </summary>
public interface IScaptonyx
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
