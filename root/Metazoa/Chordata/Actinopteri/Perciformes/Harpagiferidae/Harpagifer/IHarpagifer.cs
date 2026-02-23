namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Harpagiferidae.Harpagifer;

/// <summary>
/// Interface defining characteristics of Harpagifer (genus).
/// </summary>
public interface IHarpagifer
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
