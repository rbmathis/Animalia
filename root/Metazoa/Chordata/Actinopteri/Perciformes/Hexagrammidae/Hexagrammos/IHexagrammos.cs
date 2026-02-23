namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Hexagrammidae.Hexagrammos;

/// <summary>
/// Interface defining characteristics of Hexagrammos (genus).
/// </summary>
public interface IHexagrammos
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
