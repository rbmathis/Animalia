namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Pseudagkistrodon;

/// <summary>
/// Interface defining characteristics of Pseudagkistrodon (genus).
/// </summary>
public interface IPseudagkistrodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
