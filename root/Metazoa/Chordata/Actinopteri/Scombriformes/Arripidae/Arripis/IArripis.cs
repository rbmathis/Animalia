namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Arripidae.Arripis;

/// <summary>
/// Interface defining characteristics of Arripis (genus).
/// </summary>
public interface IArripis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
