namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Meleagris;

/// <summary>
/// Interface defining characteristics of Meleagris (genus).
/// </summary>
public interface IMeleagris
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
