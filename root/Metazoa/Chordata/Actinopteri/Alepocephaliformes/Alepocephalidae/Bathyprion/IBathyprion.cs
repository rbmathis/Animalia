namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae.Bathyprion;

/// <summary>
/// Interface defining characteristics of Bathyprion (genus).
/// </summary>
public interface IBathyprion
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
