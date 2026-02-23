namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Ducula;

/// <summary>
/// Interface defining characteristics of Ducula (genus).
/// </summary>
public interface IDucula
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
