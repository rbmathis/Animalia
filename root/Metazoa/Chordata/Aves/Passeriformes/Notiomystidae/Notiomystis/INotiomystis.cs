namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Notiomystidae.Notiomystis;

/// <summary>
/// Interface defining characteristics of Notiomystis (genus).
/// </summary>
public interface INotiomystis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
