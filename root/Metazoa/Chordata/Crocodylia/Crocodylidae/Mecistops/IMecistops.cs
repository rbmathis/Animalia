namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Crocodylidae.Mecistops;

/// <summary>
/// Interface defining characteristics of Mecistops (genus).
/// </summary>
public interface IMecistops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
