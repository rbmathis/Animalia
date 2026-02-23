namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Sarothrura;

/// <summary>
/// Interface defining characteristics of Sarothrura (genus).
/// </summary>
public interface ISarothrura
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
