namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Gymnogeophagus;

/// <summary>
/// Interface defining characteristics of Gymnogeophagus (genus).
/// </summary>
public interface IGymnogeophagus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
