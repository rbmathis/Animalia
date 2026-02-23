namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Physoschistura;

/// <summary>
/// Interface defining characteristics of Physoschistura (genus).
/// </summary>
public interface IPhysoschistura
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
