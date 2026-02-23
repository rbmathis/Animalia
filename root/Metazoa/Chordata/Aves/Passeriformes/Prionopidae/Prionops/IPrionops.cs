namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Prionopidae.Prionops;

/// <summary>
/// Interface defining characteristics of Prionops (genus).
/// </summary>
public interface IPrionops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
