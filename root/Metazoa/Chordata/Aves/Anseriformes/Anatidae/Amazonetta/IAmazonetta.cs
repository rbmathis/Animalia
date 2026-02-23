namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Amazonetta;

/// <summary>
/// Interface defining characteristics of Amazonetta (genus).
/// </summary>
public interface IAmazonetta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
