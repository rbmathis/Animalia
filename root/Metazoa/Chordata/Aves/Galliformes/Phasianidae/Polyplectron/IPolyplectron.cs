namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Polyplectron;

/// <summary>
/// Interface defining characteristics of Polyplectron (genus).
/// </summary>
public interface IPolyplectron
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
