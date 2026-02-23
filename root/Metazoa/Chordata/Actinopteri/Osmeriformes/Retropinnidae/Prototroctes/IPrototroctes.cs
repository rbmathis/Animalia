namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Retropinnidae.Prototroctes;

/// <summary>
/// Interface defining characteristics of Prototroctes (genus).
/// </summary>
public interface IPrototroctes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
