namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Caluromys;

/// <summary>
/// Interface defining characteristics of Caluromys (genus).
/// </summary>
public interface ICaluromys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
