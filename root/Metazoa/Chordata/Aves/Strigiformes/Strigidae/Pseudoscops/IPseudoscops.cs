namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Pseudoscops;

/// <summary>
/// Interface defining characteristics of Pseudoscops (genus).
/// </summary>
public interface IPseudoscops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
