namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Aramidopsis;

/// <summary>
/// Interface defining characteristics of Aramidopsis (genus).
/// </summary>
public interface IAramidopsis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
