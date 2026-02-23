namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Bathysauroididae.Bathysauroides;

/// <summary>
/// Interface defining characteristics of Bathysauroides (genus).
/// </summary>
public interface IBathysauroides
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
