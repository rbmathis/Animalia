namespace AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Kowalevskiidae.Kowalevskia;

/// <summary>
/// Interface defining characteristics of Kowalevskia (genus).
/// </summary>
public interface IKowalevskia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
