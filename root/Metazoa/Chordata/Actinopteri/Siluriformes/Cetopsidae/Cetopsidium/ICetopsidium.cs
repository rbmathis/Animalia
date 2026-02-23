namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Cetopsidae.Cetopsidium;

/// <summary>
/// Interface defining characteristics of Cetopsidium (genus).
/// </summary>
public interface ICetopsidium
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
