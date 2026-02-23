namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Canirallus;

/// <summary>
/// Interface defining characteristics of Canirallus (genus).
/// </summary>
public interface ICanirallus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
