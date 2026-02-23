namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Heteronetta;

/// <summary>
/// Interface defining characteristics of Heteronetta (genus).
/// </summary>
public interface IHeteronetta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
