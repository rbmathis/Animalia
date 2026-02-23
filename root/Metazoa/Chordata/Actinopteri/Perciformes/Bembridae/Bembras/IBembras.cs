namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bembridae.Bembras;

/// <summary>
/// Interface defining characteristics of Bembras (genus).
/// </summary>
public interface IBembras
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
