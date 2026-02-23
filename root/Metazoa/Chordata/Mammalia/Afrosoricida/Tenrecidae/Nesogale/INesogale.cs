namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Tenrecidae.Nesogale;

/// <summary>
/// Interface defining characteristics of Nesogale (genus).
/// </summary>
public interface INesogale
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
