namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Megapodiidae.Eulipoa;

/// <summary>
/// Interface defining characteristics of Eulipoa (genus).
/// </summary>
public interface IEulipoa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
