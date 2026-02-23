namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Pholidae.Pholis;

/// <summary>
/// Interface defining characteristics of Pholis (genus).
/// </summary>
public interface IPholis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
