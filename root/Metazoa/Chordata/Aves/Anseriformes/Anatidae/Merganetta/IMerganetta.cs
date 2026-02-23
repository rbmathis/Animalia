namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Merganetta;

/// <summary>
/// Interface defining characteristics of Merganetta (genus).
/// </summary>
public interface IMerganetta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
