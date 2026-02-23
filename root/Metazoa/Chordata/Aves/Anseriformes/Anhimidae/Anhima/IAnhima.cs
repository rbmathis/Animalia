namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anhimidae.Anhima;

/// <summary>
/// Interface defining characteristics of Anhima (genus).
/// </summary>
public interface IAnhima
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
