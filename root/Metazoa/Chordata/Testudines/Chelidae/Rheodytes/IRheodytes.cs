namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Rheodytes;

/// <summary>
/// Interface defining characteristics of Rheodytes (genus).
/// </summary>
public interface IRheodytes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
