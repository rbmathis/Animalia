namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhipiduridae.Rhipidura;

/// <summary>
/// Interface defining characteristics of Rhipidura (genus).
/// </summary>
public interface IRhipidura
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
