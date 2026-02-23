namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Rhabdosargus;

/// <summary>
/// Interface defining characteristics of Rhabdosargus (genus).
/// </summary>
public interface IRhabdosargus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
