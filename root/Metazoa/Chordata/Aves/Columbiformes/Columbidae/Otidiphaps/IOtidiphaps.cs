namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Otidiphaps;

/// <summary>
/// Interface defining characteristics of Otidiphaps (genus).
/// </summary>
public interface IOtidiphaps
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
