namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Brachyplatystoma;

/// <summary>
/// Interface defining characteristics of Brachyplatystoma (genus).
/// </summary>
public interface IBrachyplatystoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
