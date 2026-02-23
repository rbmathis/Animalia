namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bernieridae.Randia;

/// <summary>
/// Interface defining characteristics of Randia (genus).
/// </summary>
public interface IRandia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
