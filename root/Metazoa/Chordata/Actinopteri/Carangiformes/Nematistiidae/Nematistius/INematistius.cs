namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Nematistiidae.Nematistius;

/// <summary>
/// Interface defining characteristics of Nematistius (genus).
/// </summary>
public interface INematistius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
