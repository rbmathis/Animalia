namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Larus;

/// <summary>
/// Interface defining characteristics of Larus (genus).
/// </summary>
public interface ILarus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
