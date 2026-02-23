namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae.Chamaepetes;

/// <summary>
/// Interface defining characteristics of Chamaepetes (genus).
/// </summary>
public interface IChamaepetes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
