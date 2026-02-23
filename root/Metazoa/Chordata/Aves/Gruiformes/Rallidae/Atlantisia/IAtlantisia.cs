namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Atlantisia;

/// <summary>
/// Interface defining characteristics of Atlantisia (genus).
/// </summary>
public interface IAtlantisia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
