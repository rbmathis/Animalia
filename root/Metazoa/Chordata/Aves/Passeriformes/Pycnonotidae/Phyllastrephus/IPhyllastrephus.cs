namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Phyllastrephus;

/// <summary>
/// Interface defining characteristics of Phyllastrephus (genus).
/// </summary>
public interface IPhyllastrephus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
