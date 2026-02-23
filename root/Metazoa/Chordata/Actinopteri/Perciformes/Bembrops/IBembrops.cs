namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bembrops;

/// <summary>
/// Interface defining characteristics of Bembrops (genus).
/// </summary>
public interface IBembrops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
