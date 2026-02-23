namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Caloperdix;

/// <summary>
/// Interface defining characteristics of Caloperdix (genus).
/// </summary>
public interface ICaloperdix
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
