namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cheilodactylidae.Chirodactylus;

/// <summary>
/// Interface defining characteristics of Chirodactylus (genus).
/// </summary>
public interface IChirodactylus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
