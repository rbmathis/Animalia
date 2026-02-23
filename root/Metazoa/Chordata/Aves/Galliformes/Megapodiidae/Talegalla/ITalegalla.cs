namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Megapodiidae.Talegalla;

/// <summary>
/// Interface defining characteristics of Talegalla (genus).
/// </summary>
public interface ITalegalla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
