namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Mustelirallus;

/// <summary>
/// Interface defining characteristics of Mustelirallus (genus).
/// </summary>
public interface IMustelirallus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
