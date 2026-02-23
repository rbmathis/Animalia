namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Oxyruncus;

/// <summary>
/// Interface defining characteristics of Oxyruncus (genus).
/// </summary>
public interface IOxyruncus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
