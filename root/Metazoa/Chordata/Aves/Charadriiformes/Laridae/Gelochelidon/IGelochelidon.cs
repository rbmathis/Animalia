namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Gelochelidon;

/// <summary>
/// Interface defining characteristics of Gelochelidon (genus).
/// </summary>
public interface IGelochelidon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
