namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae.Gorilla;

/// <summary>
/// Interface defining characteristics of Gorilla (genus).
/// </summary>
public interface IGorilla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
