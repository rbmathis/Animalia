namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Arborophila;

/// <summary>
/// Interface defining characteristics of Arborophila (genus).
/// </summary>
public interface IArborophila
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
