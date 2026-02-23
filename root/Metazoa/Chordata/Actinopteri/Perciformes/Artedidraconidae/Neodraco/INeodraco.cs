namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Artedidraconidae.Neodraco;

/// <summary>
/// Interface defining characteristics of Neodraco (genus).
/// </summary>
public interface INeodraco
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
