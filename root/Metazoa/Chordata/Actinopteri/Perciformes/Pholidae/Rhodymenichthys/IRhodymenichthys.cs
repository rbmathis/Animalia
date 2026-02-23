namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Pholidae.Rhodymenichthys;

/// <summary>
/// Interface defining characteristics of Rhodymenichthys (genus).
/// </summary>
public interface IRhodymenichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
