namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Mammutidae.Mammut;

/// <summary>
/// Interface defining characteristics of Mammut (genus).
/// </summary>
public interface IMammut
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
