namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Nesotrochis;

/// <summary>
/// Interface defining characteristics of Nesotrochis (genus).
/// </summary>
public interface INesotrochis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
