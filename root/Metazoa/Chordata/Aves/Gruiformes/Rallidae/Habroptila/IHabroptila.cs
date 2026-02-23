namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Habroptila;

/// <summary>
/// Interface defining characteristics of Habroptila (genus).
/// </summary>
public interface IHabroptila
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
