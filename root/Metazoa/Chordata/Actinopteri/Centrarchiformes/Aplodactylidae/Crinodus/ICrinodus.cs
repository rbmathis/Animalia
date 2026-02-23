namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Aplodactylidae.Crinodus;

/// <summary>
/// Interface defining characteristics of Crinodus (genus).
/// </summary>
public interface ICrinodus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
