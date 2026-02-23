namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Recurvirostridae.Himantopus;

/// <summary>
/// Interface defining characteristics of Himantopus (genus).
/// </summary>
public interface IHimantopus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
