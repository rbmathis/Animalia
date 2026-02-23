namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Peliperdix;

/// <summary>
/// Interface defining characteristics of Peliperdix (genus).
/// </summary>
public interface IPeliperdix
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
