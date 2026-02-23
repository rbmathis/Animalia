namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Eurylaimidae.Corydon;

/// <summary>
/// Interface defining characteristics of Corydon (genus).
/// </summary>
public interface ICorydon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
