namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Glaucosomatidae.Glaucosoma;

/// <summary>
/// Interface defining characteristics of Glaucosoma (genus).
/// </summary>
public interface IGlaucosoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
