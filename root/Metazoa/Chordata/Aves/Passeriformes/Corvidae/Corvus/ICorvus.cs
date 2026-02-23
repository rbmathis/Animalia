namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Corvus;

/// <summary>
/// Interface defining characteristics of Corvus (genus).
/// </summary>
public interface ICorvus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
