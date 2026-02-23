namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae.Atherion;

/// <summary>
/// Interface defining characteristics of Atherion (genus).
/// </summary>
public interface IAtherion
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
