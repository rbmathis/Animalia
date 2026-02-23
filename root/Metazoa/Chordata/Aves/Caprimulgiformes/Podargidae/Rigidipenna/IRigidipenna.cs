namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Podargidae.Rigidipenna;

/// <summary>
/// Interface defining characteristics of Rigidipenna (genus).
/// </summary>
public interface IRigidipenna
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
