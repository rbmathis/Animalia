namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Paragallinula;

/// <summary>
/// Interface defining characteristics of Paragallinula (genus).
/// </summary>
public interface IParagallinula
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
