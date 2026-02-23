namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Leptotila;

/// <summary>
/// Interface defining characteristics of Leptotila (genus).
/// </summary>
public interface ILeptotila
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
