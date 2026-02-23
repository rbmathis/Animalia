namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae.Trochalopteron;

/// <summary>
/// Interface defining characteristics of Trochalopteron (genus).
/// </summary>
public interface ITrochalopteron
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
