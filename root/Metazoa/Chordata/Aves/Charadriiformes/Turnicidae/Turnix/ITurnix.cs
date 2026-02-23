namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Turnicidae.Turnix;

/// <summary>
/// Interface defining characteristics of Turnix (genus).
/// </summary>
public interface ITurnix
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
