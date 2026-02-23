namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Pseudoleptodeira;

/// <summary>
/// Interface defining characteristics of Pseudoleptodeira (genus).
/// </summary>
public interface IPseudoleptodeira
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
