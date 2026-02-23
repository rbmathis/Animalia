namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Perdix;

/// <summary>
/// Interface defining characteristics of Perdix (genus).
/// </summary>
public interface IPerdix
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
