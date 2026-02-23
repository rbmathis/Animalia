namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Glyptosternon;

/// <summary>
/// Interface defining characteristics of Glyptosternon (genus).
/// </summary>
public interface IGlyptosternon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
