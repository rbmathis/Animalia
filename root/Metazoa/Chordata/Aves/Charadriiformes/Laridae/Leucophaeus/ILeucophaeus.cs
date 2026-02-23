namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Leucophaeus;

/// <summary>
/// Interface defining characteristics of Leucophaeus (genus).
/// </summary>
public interface ILeucophaeus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
