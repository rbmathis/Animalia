namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Ammoperdix;

/// <summary>
/// Interface defining characteristics of Ammoperdix (genus).
/// </summary>
public interface IAmmoperdix
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
