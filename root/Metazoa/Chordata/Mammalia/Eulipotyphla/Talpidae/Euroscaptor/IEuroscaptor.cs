namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Euroscaptor;

/// <summary>
/// Interface defining characteristics of Euroscaptor (genus).
/// </summary>
public interface IEuroscaptor
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
