namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Oriturus;

/// <summary>
/// Interface defining characteristics of Oriturus (genus).
/// </summary>
public interface IOriturus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
