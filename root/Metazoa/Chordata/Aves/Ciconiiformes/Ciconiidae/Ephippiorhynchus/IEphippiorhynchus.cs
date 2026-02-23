namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Ciconiiformes.Ciconiidae.Ephippiorhynchus;

/// <summary>
/// Interface defining characteristics of Ephippiorhynchus (genus).
/// </summary>
public interface IEphippiorhynchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
