namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Sibirionetta;

/// <summary>
/// Interface defining characteristics of Sibirionetta (genus).
/// </summary>
public interface ISibirionetta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
