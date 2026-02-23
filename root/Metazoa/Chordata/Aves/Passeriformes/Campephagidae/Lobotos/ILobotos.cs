namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Campephagidae.Lobotos;

/// <summary>
/// Interface defining characteristics of Lobotos (genus).
/// </summary>
public interface ILobotos
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
