namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Lophonetta;

/// <summary>
/// Interface defining characteristics of Lophonetta (genus).
/// </summary>
public interface ILophonetta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
