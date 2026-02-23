namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Gnorimopsar;

/// <summary>
/// Interface defining characteristics of Gnorimopsar (genus).
/// </summary>
public interface IGnorimopsar
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
