namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dendrocolaptidae.Dendrocincla;

/// <summary>
/// Interface defining characteristics of Dendrocincla (genus).
/// </summary>
public interface IDendrocincla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
