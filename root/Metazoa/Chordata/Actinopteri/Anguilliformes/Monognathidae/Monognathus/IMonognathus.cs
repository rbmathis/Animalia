namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Monognathidae.Monognathus;

/// <summary>
/// Interface defining characteristics of Monognathus (genus).
/// </summary>
public interface IMonognathus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
