namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Rhinotocinclus;

/// <summary>
/// Interface defining characteristics of Rhinotocinclus (genus).
/// </summary>
public interface IRhinotocinclus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
