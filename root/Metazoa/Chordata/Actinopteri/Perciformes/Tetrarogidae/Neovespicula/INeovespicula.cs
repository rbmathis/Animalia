namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae.Neovespicula;

/// <summary>
/// Interface defining characteristics of Neovespicula (genus).
/// </summary>
public interface INeovespicula
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
