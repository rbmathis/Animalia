namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Gliridae.Glirulus;

/// <summary>
/// Interface defining characteristics of Glirulus (genus).
/// </summary>
public interface IGlirulus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
