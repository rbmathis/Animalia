namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Didunculus;

/// <summary>
/// Interface defining characteristics of Didunculus (genus).
/// </summary>
public interface IDidunculus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
