namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Akysidae.Parakysis;

/// <summary>
/// Interface defining characteristics of Parakysis (genus).
/// </summary>
public interface IParakysis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
