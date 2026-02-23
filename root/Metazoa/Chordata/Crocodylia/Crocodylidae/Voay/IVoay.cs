namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Crocodylidae.Voay;

/// <summary>
/// Interface defining characteristics of Voay (genus).
/// </summary>
public interface IVoay
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
