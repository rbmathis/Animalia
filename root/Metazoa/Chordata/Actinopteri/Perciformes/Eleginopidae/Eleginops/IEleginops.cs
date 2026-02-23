namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Eleginopidae.Eleginops;

/// <summary>
/// Interface defining characteristics of Eleginops (genus).
/// </summary>
public interface IEleginops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
