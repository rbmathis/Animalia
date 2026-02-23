namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Tropicoperdix;

/// <summary>
/// Interface defining characteristics of Tropicoperdix (genus).
/// </summary>
public interface ITropicoperdix
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
