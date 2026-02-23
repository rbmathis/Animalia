namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Neochela;

/// <summary>
/// Interface defining characteristics of Neochela (genus).
/// </summary>
public interface INeochela
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
