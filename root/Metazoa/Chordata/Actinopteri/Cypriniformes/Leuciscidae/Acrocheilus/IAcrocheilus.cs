namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Acrocheilus;

/// <summary>
/// Interface defining characteristics of Acrocheilus (genus).
/// </summary>
public interface IAcrocheilus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
