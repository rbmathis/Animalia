namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Claroteidae.Bathybagrus;

/// <summary>
/// Interface defining characteristics of Bathybagrus (genus).
/// </summary>
public interface IBathybagrus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
