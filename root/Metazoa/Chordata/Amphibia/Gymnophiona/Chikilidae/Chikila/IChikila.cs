namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Chikilidae.Chikila;

/// <summary>
/// Interface defining characteristics of Chikila (genus).
/// </summary>
public interface IChikila
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
