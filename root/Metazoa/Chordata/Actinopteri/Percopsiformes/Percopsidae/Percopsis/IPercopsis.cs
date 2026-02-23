namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Percopsiformes.Percopsidae.Percopsis;

/// <summary>
/// Interface defining characteristics of Percopsis (genus).
/// </summary>
public interface IPercopsis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
