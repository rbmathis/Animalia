namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Podargidae.Podargus;

/// <summary>
/// Interface defining characteristics of Podargus (genus).
/// </summary>
public interface IPodargus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
