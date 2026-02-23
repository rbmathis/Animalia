namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Ellopostomatidae.Ellopostoma;

/// <summary>
/// Interface defining characteristics of Ellopostoma (genus).
/// </summary>
public interface IEllopostoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
