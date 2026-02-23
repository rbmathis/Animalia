namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Oxynotidae.Oxynotus;

/// <summary>
/// Interface defining characteristics of Oxynotus (genus).
/// </summary>
public interface IOxynotus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
