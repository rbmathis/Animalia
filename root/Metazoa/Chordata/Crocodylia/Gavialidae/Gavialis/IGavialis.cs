namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Gavialidae.Gavialis;

/// <summary>
/// Interface defining characteristics of Gavialis (genus).
/// </summary>
public interface IGavialis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
