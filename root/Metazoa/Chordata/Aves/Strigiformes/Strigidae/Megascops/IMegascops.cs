namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Megascops;

/// <summary>
/// Interface defining characteristics of Megascops (genus).
/// </summary>
public interface IMegascops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
