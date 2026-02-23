namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Tarsipedidae.Tarsipes;

/// <summary>
/// Interface defining characteristics of Tarsipes (genus).
/// </summary>
public interface ITarsipes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
