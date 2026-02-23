namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ploceidae.Amblyospiza;

/// <summary>
/// Interface defining characteristics of Amblyospiza (genus).
/// </summary>
public interface IAmblyospiza
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
