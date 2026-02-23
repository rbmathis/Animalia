namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Galloperdix;

/// <summary>
/// Interface defining characteristics of Galloperdix (genus).
/// </summary>
public interface IGalloperdix
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
