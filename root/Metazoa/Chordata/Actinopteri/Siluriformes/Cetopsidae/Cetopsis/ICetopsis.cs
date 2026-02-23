namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Cetopsidae.Cetopsis;

/// <summary>
/// Interface defining characteristics of Cetopsis (genus).
/// </summary>
public interface ICetopsis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
