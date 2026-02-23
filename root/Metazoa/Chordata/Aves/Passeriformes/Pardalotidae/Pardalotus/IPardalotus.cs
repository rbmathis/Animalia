namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pardalotidae.Pardalotus;

/// <summary>
/// Interface defining characteristics of Pardalotus (genus).
/// </summary>
public interface IPardalotus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
