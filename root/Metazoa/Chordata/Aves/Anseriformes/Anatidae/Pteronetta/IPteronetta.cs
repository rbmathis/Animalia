namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Pteronetta;

/// <summary>
/// Interface defining characteristics of Pteronetta (genus).
/// </summary>
public interface IPteronetta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
