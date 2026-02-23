namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Crocodylidae.Crocodylus;

/// <summary>
/// Interface defining characteristics of Crocodylus (genus).
/// </summary>
public interface ICrocodylus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
