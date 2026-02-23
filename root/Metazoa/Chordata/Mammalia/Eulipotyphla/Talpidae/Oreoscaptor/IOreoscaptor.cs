namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Oreoscaptor;

/// <summary>
/// Interface defining characteristics of Oreoscaptor (genus).
/// </summary>
public interface IOreoscaptor
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
