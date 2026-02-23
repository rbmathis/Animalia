namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Locustellidae.Locustella;

/// <summary>
/// Interface defining characteristics of Locustella (genus).
/// </summary>
public interface ILocustella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
