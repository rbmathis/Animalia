namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Alaemon;

/// <summary>
/// Interface defining characteristics of Alaemon (genus).
/// </summary>
public interface IAlaemon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
