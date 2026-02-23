namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae.Lepidonotothen;

/// <summary>
/// Interface defining characteristics of Lepidonotothen (genus).
/// </summary>
public interface ILepidonotothen
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
