namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Serpenticobitidae.Serpenticobitis;

/// <summary>
/// Interface defining characteristics of Serpenticobitis (genus).
/// </summary>
public interface ISerpenticobitis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
