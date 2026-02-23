namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Colluricincla;

/// <summary>
/// Interface defining characteristics of Colluricincla (genus).
/// </summary>
public interface IColluricincla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
