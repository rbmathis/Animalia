namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Nesopsar;

/// <summary>
/// Interface defining characteristics of Nesopsar (genus).
/// </summary>
public interface INesopsar
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
