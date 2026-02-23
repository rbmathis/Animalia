namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Cociella;

/// <summary>
/// Interface defining characteristics of Cociella (genus).
/// </summary>
public interface ICociella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
