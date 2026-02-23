namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lanthanotidae.Lanthanotus;

/// <summary>
/// Interface defining characteristics of Lanthanotus (genus).
/// </summary>
public interface ILanthanotus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
