namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bembridae.Bembradium;

/// <summary>
/// Interface defining characteristics of Bembradium (genus).
/// </summary>
public interface IBembradium
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
