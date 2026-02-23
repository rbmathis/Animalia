namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Cacatuidae.Calyptorhynchus;

/// <summary>
/// Interface defining characteristics of Calyptorhynchus (genus).
/// </summary>
public interface ICalyptorhynchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
