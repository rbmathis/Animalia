namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Crex;

/// <summary>
/// Interface defining characteristics of Crex (genus).
/// </summary>
public interface ICrex
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
