namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Acanthochelys;

/// <summary>
/// Interface defining characteristics of Acanthochelys (genus).
/// </summary>
public interface IAcanthochelys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
