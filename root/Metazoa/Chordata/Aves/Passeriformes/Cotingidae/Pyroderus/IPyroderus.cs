namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Pyroderus;

/// <summary>
/// Interface defining characteristics of Pyroderus (genus).
/// </summary>
public interface IPyroderus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
