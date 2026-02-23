namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anarhichadidae.Anarhichas;

/// <summary>
/// Interface defining characteristics of Anarhichas (genus).
/// </summary>
public interface IAnarhichas
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
