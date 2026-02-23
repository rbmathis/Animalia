namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Glyphorynchus;

/// <summary>
/// Interface defining characteristics of Glyphorynchus (genus).
/// </summary>
public interface IGlyphorynchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
