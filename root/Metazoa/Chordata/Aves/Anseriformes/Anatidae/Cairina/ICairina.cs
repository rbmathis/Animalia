namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Cairina;

/// <summary>
/// Interface defining characteristics of Cairina (genus).
/// </summary>
public interface ICairina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
