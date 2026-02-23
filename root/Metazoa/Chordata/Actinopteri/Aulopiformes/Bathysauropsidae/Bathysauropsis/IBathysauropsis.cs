namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Bathysauropsidae.Bathysauropsis;

/// <summary>
/// Interface defining characteristics of Bathysauropsis (genus).
/// </summary>
public interface IBathysauropsis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
