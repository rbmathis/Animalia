namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Galagidae.Galagoides;

/// <summary>
/// Interface defining characteristics of Galagoides (genus).
/// </summary>
public interface IGalagoides
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
