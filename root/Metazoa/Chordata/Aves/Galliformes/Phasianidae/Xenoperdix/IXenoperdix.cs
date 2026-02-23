namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Xenoperdix;

/// <summary>
/// Interface defining characteristics of Xenoperdix (genus).
/// </summary>
public interface IXenoperdix
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
