namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Margaroperdix;

/// <summary>
/// Interface defining characteristics of Margaroperdix (genus).
/// </summary>
public interface IMargaroperdix
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
