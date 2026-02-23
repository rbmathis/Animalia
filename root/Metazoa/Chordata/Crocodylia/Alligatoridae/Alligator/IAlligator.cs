namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Alligatoridae.Alligator;

/// <summary>
/// Interface defining characteristics of Alligator (genus).
/// </summary>
public interface IAlligator
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
