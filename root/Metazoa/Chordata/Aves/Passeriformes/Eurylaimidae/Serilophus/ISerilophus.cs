namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Eurylaimidae.Serilophus;

/// <summary>
/// Interface defining characteristics of Serilophus (genus).
/// </summary>
public interface ISerilophus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
