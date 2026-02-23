namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Gymnotocinclus;

/// <summary>
/// Interface defining characteristics of Gymnotocinclus (genus).
/// </summary>
public interface IGymnotocinclus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
