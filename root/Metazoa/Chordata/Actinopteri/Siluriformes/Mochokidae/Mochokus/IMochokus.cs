namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Mochokidae.Mochokus;

/// <summary>
/// Interface defining characteristics of Mochokus (genus).
/// </summary>
public interface IMochokus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
