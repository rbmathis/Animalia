namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Phaetusa;

/// <summary>
/// Interface defining characteristics of Phaetusa (genus).
/// </summary>
public interface IPhaetusa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
