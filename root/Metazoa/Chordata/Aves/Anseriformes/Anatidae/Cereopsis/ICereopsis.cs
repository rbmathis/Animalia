namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Cereopsis;

/// <summary>
/// Interface defining characteristics of Cereopsis (genus).
/// </summary>
public interface ICereopsis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
