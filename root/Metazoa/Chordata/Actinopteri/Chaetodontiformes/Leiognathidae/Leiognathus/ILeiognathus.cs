namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae.Leiognathus;

/// <summary>
/// Interface defining characteristics of Leiognathus (genus).
/// </summary>
public interface ILeiognathus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
