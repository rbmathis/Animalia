namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Brachypteraciidae.Brachypteracias;

/// <summary>
/// Interface defining characteristics of Brachypteracias (genus).
/// </summary>
public interface IBrachypteracias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
