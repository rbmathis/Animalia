namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Nucifraga;

/// <summary>
/// Interface defining characteristics of Nucifraga (genus).
/// </summary>
public interface INucifraga
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
