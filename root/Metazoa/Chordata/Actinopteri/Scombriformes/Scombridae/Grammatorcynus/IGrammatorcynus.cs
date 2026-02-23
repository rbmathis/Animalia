namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Grammatorcynus;

/// <summary>
/// Interface defining characteristics of Grammatorcynus (genus).
/// </summary>
public interface IGrammatorcynus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
