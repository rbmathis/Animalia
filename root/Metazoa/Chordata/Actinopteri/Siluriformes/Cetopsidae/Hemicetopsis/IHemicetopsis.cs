namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Cetopsidae.Hemicetopsis;

/// <summary>
/// Interface defining characteristics of Hemicetopsis (genus).
/// </summary>
public interface IHemicetopsis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
