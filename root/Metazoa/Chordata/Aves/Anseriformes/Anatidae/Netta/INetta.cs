namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Netta;

/// <summary>
/// Interface defining characteristics of Netta (genus).
/// </summary>
public interface INetta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
