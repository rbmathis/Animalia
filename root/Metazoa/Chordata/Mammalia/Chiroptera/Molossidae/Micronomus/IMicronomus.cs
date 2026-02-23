namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Micronomus;

/// <summary>
/// Interface defining characteristics of Micronomus (genus).
/// </summary>
public interface IMicronomus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
