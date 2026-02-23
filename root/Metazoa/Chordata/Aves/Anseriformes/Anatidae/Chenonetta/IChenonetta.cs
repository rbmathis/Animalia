namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Chenonetta;

/// <summary>
/// Interface defining characteristics of Chenonetta (genus).
/// </summary>
public interface IChenonetta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
