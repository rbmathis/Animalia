namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae.Patagonotothen;

/// <summary>
/// Interface defining characteristics of Patagonotothen (genus).
/// </summary>
public interface IPatagonotothen
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
