namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Cetopsidae.Pseudocetopsis;

/// <summary>
/// Interface defining characteristics of Pseudocetopsis (genus).
/// </summary>
public interface IPseudocetopsis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
