namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Lybiidae.Buccanodon;

/// <summary>
/// Interface defining characteristics of Buccanodon (genus).
/// </summary>
public interface IBuccanodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
