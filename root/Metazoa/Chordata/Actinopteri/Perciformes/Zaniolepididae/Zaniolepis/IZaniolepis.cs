namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zaniolepididae.Zaniolepis;

/// <summary>
/// Interface defining characteristics of Zaniolepis (genus).
/// </summary>
public interface IZaniolepis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
