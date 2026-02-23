namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Pseudalaemon;

/// <summary>
/// Interface defining characteristics of Pseudalaemon (genus).
/// </summary>
public interface IPseudalaemon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
