namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Tenrecidae.Geogale;

/// <summary>
/// Interface defining characteristics of Geogale (genus).
/// </summary>
public interface IGeogale
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
