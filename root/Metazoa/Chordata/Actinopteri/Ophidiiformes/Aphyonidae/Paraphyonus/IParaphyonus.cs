namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Aphyonidae.Paraphyonus;

/// <summary>
/// Interface defining characteristics of Paraphyonus (genus).
/// </summary>
public interface IParaphyonus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
