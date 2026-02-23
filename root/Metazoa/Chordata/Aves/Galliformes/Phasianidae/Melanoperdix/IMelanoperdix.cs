namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Melanoperdix;

/// <summary>
/// Interface defining characteristics of Melanoperdix (genus).
/// </summary>
public interface IMelanoperdix
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
