namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Formicariidae.Pittasoma;

/// <summary>
/// Interface defining characteristics of Pittasoma (genus).
/// </summary>
public interface IPittasoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
