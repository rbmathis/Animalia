namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Chlopsidae.Robinsia;

/// <summary>
/// Interface defining characteristics of Robinsia (genus).
/// </summary>
public interface IRobinsia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
