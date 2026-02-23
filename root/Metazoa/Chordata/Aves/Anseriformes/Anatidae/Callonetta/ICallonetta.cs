namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Callonetta;

/// <summary>
/// Interface defining characteristics of Callonetta (genus).
/// </summary>
public interface ICallonetta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
