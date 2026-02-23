namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ploceidae.Histurgops;

/// <summary>
/// Interface defining characteristics of Histurgops (genus).
/// </summary>
public interface IHisturgops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
