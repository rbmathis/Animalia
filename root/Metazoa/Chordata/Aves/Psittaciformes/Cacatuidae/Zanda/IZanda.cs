namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Cacatuidae.Zanda;

/// <summary>
/// Interface defining characteristics of Zanda (genus).
/// </summary>
public interface IZanda
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
