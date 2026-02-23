namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Neopelma;

/// <summary>
/// Interface defining characteristics of Neopelma (genus).
/// </summary>
public interface INeopelma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
