namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Columbina;

/// <summary>
/// Interface defining characteristics of Columbina (genus).
/// </summary>
public interface IColumbina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
