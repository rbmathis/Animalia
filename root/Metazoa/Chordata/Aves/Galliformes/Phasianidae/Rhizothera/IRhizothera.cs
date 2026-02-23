namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Rhizothera;

/// <summary>
/// Interface defining characteristics of Rhizothera (genus).
/// </summary>
public interface IRhizothera
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
