namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Lafresnaya;

/// <summary>
/// Interface defining characteristics of Lafresnaya (genus).
/// </summary>
public interface ILafresnaya
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
