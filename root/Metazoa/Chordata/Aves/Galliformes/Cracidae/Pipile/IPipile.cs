namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae.Pipile;

/// <summary>
/// Interface defining characteristics of Pipile (genus).
/// </summary>
public interface IPipile
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
