namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Cylindraspis;

/// <summary>
/// Interface defining characteristics of Cylindraspis (genus).
/// </summary>
public interface ICylindraspis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
