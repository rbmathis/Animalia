namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Ctenobrycon;

/// <summary>
/// Interface defining characteristics of Ctenobrycon (genus).
/// </summary>
public interface ICtenobrycon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
