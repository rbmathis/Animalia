namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Rostratulidae.Nycticryphes;

/// <summary>
/// Interface defining characteristics of Nycticryphes (genus).
/// </summary>
public interface INycticryphes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
