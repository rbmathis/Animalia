namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Hylocichla;

/// <summary>
/// Interface defining characteristics of Hylocichla (genus).
/// </summary>
public interface IHylocichla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
