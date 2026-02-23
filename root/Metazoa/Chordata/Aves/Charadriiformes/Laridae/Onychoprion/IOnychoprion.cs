namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Onychoprion;

/// <summary>
/// Interface defining characteristics of Onychoprion (genus).
/// </summary>
public interface IOnychoprion
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
