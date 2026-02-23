namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Rynchops;

/// <summary>
/// Interface defining characteristics of Rynchops (genus).
/// </summary>
public interface IRynchops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
