namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Aphelocoma;

/// <summary>
/// Interface defining characteristics of Aphelocoma (genus).
/// </summary>
public interface IAphelocoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
