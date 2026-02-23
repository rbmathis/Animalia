namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Ridgwayia;

/// <summary>
/// Interface defining characteristics of Ridgwayia (genus).
/// </summary>
public interface IRidgwayia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
