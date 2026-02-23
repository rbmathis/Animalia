namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Raphidae.Pezophaps;

/// <summary>
/// Interface defining characteristics of Pezophaps (genus).
/// </summary>
public interface IPezophaps
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
