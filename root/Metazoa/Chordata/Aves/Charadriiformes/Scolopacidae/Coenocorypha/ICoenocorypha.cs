namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Coenocorypha;

/// <summary>
/// Interface defining characteristics of Coenocorypha (genus).
/// </summary>
public interface ICoenocorypha
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
