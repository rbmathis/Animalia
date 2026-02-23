namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Spatula;

/// <summary>
/// Interface defining characteristics of Spatula (genus).
/// </summary>
public interface ISpatula
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
