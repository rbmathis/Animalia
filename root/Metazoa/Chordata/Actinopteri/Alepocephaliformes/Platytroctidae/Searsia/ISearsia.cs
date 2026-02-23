namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Platytroctidae.Searsia;

/// <summary>
/// Interface defining characteristics of Searsia (genus).
/// </summary>
public interface ISearsia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
