namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Sebastidae.Helicolenus;

/// <summary>
/// Interface defining characteristics of Helicolenus (genus).
/// </summary>
public interface IHelicolenus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
