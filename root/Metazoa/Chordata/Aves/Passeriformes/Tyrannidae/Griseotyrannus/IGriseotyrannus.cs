namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Griseotyrannus;

/// <summary>
/// Interface defining characteristics of Griseotyrannus (genus).
/// </summary>
public interface IGriseotyrannus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
