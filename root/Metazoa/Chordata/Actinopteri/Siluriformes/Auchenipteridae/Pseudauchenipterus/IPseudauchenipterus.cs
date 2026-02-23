namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Pseudauchenipterus;

/// <summary>
/// Interface defining characteristics of Pseudauchenipterus (genus).
/// </summary>
public interface IPseudauchenipterus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
