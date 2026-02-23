namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Somateria;

/// <summary>
/// Interface defining characteristics of Somateria (genus).
/// </summary>
public interface ISomateria
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
