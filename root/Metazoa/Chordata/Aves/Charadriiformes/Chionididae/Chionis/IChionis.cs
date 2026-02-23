namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Chionididae.Chionis;

/// <summary>
/// Interface defining characteristics of Chionis (genus).
/// </summary>
public interface IChionis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
