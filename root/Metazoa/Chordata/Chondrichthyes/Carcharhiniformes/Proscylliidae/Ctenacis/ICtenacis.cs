namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Proscylliidae.Ctenacis;

/// <summary>
/// Interface defining characteristics of Ctenacis (genus).
/// </summary>
public interface ICtenacis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
