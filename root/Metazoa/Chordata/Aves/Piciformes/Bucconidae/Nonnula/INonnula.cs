namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Bucconidae.Nonnula;

/// <summary>
/// Interface defining characteristics of Nonnula (genus).
/// </summary>
public interface INonnula
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
