namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Noctilionidae.Noctilio;

/// <summary>
/// Interface defining characteristics of Noctilio (genus).
/// </summary>
public interface INoctilio
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
