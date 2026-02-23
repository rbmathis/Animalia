namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Hemigaleidae.Hemipristis;

/// <summary>
/// Interface defining characteristics of Hemipristis (genus).
/// </summary>
public interface IHemipristis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
