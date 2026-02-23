namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Musophagiformes.Musophagidae.Musophaga;

/// <summary>
/// Interface defining characteristics of Musophaga (genus).
/// </summary>
public interface IMusophaga
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
