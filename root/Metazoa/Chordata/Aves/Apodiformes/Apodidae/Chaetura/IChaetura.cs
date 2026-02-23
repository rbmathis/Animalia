namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Chaetura;

/// <summary>
/// Interface defining characteristics of Chaetura (genus).
/// </summary>
public interface IChaetura
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
