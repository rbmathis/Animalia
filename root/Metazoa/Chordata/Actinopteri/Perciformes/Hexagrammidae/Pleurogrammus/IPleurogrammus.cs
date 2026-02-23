namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Hexagrammidae.Pleurogrammus;

/// <summary>
/// Interface defining characteristics of Pleurogrammus (genus).
/// </summary>
public interface IPleurogrammus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
