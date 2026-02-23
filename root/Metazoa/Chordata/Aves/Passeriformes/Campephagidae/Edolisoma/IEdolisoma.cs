namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Campephagidae.Edolisoma;

/// <summary>
/// Interface defining characteristics of Edolisoma (genus).
/// </summary>
public interface IEdolisoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
