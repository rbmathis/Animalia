namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Acanthocobitis;

/// <summary>
/// Interface defining characteristics of Acanthocobitis (genus).
/// </summary>
public interface IAcanthocobitis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
