namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Oreosomatidae.Oreosoma;

/// <summary>
/// Interface defining characteristics of Oreosoma (genus).
/// </summary>
public interface IOreosoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
