namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Heinrichia;

/// <summary>
/// Interface defining characteristics of Heinrichia (genus).
/// </summary>
public interface IHeinrichia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
