namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Francolinus;

/// <summary>
/// Interface defining characteristics of Francolinus (genus).
/// </summary>
public interface IFrancolinus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
