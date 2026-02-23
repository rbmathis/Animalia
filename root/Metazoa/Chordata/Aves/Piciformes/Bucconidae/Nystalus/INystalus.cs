namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Bucconidae.Nystalus;

/// <summary>
/// Interface defining characteristics of Nystalus (genus).
/// </summary>
public interface INystalus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
