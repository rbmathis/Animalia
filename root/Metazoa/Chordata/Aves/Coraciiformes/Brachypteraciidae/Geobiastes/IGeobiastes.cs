namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Brachypteraciidae.Geobiastes;

/// <summary>
/// Interface defining characteristics of Geobiastes (genus).
/// </summary>
public interface IGeobiastes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
