namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Pedetidae.Pedetes;

/// <summary>
/// Interface defining characteristics of Pedetes (genus).
/// </summary>
public interface IPedetes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
