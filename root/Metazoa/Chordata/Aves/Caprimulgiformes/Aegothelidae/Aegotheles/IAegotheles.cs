namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Aegothelidae.Aegotheles;

/// <summary>
/// Interface defining characteristics of Aegotheles (genus).
/// </summary>
public interface IAegotheles
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
