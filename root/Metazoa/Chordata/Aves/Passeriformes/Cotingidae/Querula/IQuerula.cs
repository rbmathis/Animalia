namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Querula;

/// <summary>
/// Interface defining characteristics of Querula (genus).
/// </summary>
public interface IQuerula
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
