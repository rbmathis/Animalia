namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Pardirallus;

/// <summary>
/// Interface defining characteristics of Pardirallus (genus).
/// </summary>
public interface IPardirallus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
