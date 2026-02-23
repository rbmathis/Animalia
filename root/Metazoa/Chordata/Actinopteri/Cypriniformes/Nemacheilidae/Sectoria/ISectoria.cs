namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Sectoria;

/// <summary>
/// Interface defining characteristics of Sectoria (genus).
/// </summary>
public interface ISectoria
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
