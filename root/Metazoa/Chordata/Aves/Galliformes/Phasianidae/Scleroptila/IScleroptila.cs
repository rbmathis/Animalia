namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Scleroptila;

/// <summary>
/// Interface defining characteristics of Scleroptila (genus).
/// </summary>
public interface IScleroptila
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
