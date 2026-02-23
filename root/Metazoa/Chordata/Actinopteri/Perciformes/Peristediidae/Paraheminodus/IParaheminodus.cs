namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Peristediidae.Paraheminodus;

/// <summary>
/// Interface defining characteristics of Paraheminodus (genus).
/// </summary>
public interface IParaheminodus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
