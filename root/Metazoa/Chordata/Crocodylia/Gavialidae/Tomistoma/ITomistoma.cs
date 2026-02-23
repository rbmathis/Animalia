namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Gavialidae.Tomistoma;

/// <summary>
/// Interface defining characteristics of Tomistoma (genus).
/// </summary>
public interface ITomistoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
