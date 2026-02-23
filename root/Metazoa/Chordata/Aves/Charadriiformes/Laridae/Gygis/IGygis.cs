namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Gygis;

/// <summary>
/// Interface defining characteristics of Gygis (genus).
/// </summary>
public interface IGygis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
