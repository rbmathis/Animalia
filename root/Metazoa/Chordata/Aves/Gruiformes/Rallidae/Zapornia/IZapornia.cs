namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Zapornia;

/// <summary>
/// Interface defining characteristics of Zapornia (genus).
/// </summary>
public interface IZapornia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
