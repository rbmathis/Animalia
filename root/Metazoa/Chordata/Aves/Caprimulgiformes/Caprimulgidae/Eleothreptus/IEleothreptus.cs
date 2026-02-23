namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae.Eleothreptus;

/// <summary>
/// Interface defining characteristics of Eleothreptus (genus).
/// </summary>
public interface IEleothreptus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
