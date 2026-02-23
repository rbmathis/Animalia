namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Mergellus;

/// <summary>
/// Interface defining characteristics of Mergellus (genus).
/// </summary>
public interface IMergellus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
